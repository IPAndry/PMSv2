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
    
    // ��� ������� ������ "������"
    void OnShopBtnClicked(int itemIndex)
    {
        // ���� ���� � �������� �������� �������� �������, ��� ���������� ����� � �����
        if (Gameme.Instance.HasEnoughCoins(ShopItemsList[itemIndex].Price))
        {
            // �� �������� �� ���������� ����� �����
            Gameme.Instance.UseCoins(ShopItemsList[itemIndex].Price);

            print(itemIndex);
            // �������� �������
            ShopItemsList[itemIndex].isPurchase = true;

            // ��������� ������ �������
            buyBtn = ShopScrollView.GetChild(itemIndex).GetChild(2).GetComponent<Button>();
            DisableBuyButton();

            // ��������� ������� �����
            Gameme.Instance.UpdateAllCoinsUIText();

            // ��������� �������
            Profile.Instance.AddItem(ShopItemsList[itemIndex].Image);
        }
        // �����
        else
        {
            // ������� �������� "��� �����"
            NoMoneyAnim.SetTrigger("NoMoney");
        }
    }

    void DisableBuyButton()
    {
        buyBtn.interactable = false;
        buyBtn.transform.GetChild(0).GetComponent<Text>().text = "�������";
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
