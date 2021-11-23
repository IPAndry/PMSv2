using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    #region Singlton:Shop

    public static Shop Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion


    [System.Serializable] public class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool isPurchase = false;
    }

    public List<ShopItem> ShopItemsList;

    [SerializeField] Animator NoMoneyAnim;

    [SerializeField] GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    [SerializeField] GameObject ShopPanel;

    Button buyBtn;

    private void Start()
    {
        int len = ShopItemsList.Count;
        for (int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;
            g.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemsList[i].Price.ToString();
            buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            if (ShopItemsList[i].isPurchase)
            {
                DisableBuyButton();
            }
            buyBtn.AddEventListener(i, OnShopBtnClicked);
        }
    }
    
    // При нажатии кнопки "Купить"
    void OnShopBtnClicked(int itemIndex)
    {
        // Если цена у нажатого предмета является меньшей, чем количество денег у юзера
        if (Gameme.Instance.HasEnoughCoins(ShopItemsList[itemIndex].Price))
        {
            // То отнимаем от количества денег сумму
            Gameme.Instance.UseCoins(ShopItemsList[itemIndex].Price);

            print(itemIndex);
            // Покупаем предмет
            ShopItemsList[itemIndex].isPurchase = true;

            // Выключаем кнопку покупки
            buyBtn = ShopScrollView.GetChild(itemIndex).GetChild(2).GetComponent<Button>();
            DisableBuyButton();

            // Обновляем счётчик денег
            Gameme.Instance.UpdateAllCoinsUIText();

            // Добавляем предмет
            Profile.Instance.AddItem(ShopItemsList[itemIndex].Image);
        }
        // Иначе
        else
        {
            // Триггер анимации "Нет денег"
            NoMoneyAnim.SetTrigger("NoMoney");
        }
    }

    void DisableBuyButton()
    {
        buyBtn.interactable = false;
        buyBtn.transform.GetChild(0).GetComponent<Text>().text = "Куплено";
    }

    // Close and Open Shop
    public void OpenShop()
    {
        ShopPanel.SetActive(true);
    }
    public void CloseShop()
    {
        ShopPanel.SetActive(false);
    }

}
