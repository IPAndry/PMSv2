using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    #region SInglton:Profile

    public static Profile Instance;

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

    public class Item
    {
        public Sprite Image;
    }

    public List<Item> ItemList;

    [SerializeField] GameObject ItemUITemplate;
    [SerializeField] Transform AvatarScrollView;

    GameObject g;
    int newSelectedIndex, previousSelectedIndex;

    [SerializeField] Color ActiveAvatarColor;
    [SerializeField] Color DefaultAvatarColor;

    [SerializeField] Image CurrentAvatar;

    private void Start()
    {
        GetAvailableItems();
        newSelectedIndex = previousSelectedIndex = 0;
    }

    private void GetAvailableItems()
    {
        for (int i = 0; i < Shop.Instance.ShopItemsList.Count; i++)
        {
            if (Shop.Instance.ShopItemsList[i].isPurchase)
            {
                // add purchased items
                AddItem(Shop.Instance.ShopItemsList[i].Image);
            }
        }

        SelectAvatar(newSelectedIndex);
    }

    public void AddItem(Sprite img)
    {
        if (ItemList == null)
            ItemList = new List<Item>();

        Item itm = new Item() { Image = img };

        // add itm to ItemList
        ItemList.Add(itm);

        // add item in the UI scroll view
        g = Instantiate(ItemUITemplate, AvatarScrollView);
        g.transform.GetChild(0).GetComponent<Image>().sprite = itm.Image;

        // add click event
        g.transform.GetComponent<Button>().AddEventListener(ItemList.Count - 1, OnAvatarClick);
    }

    void OnAvatarClick(int AvatarIndex)
    {
        SelectAvatar(AvatarIndex);
    }

    void SelectAvatar(int AvatarIndex)
    {
        previousSelectedIndex = newSelectedIndex;
        newSelectedIndex = AvatarIndex;
        AvatarScrollView.GetChild(previousSelectedIndex).GetComponent<Image>().color = DefaultAvatarColor;
        AvatarScrollView.GetChild(newSelectedIndex).GetComponent<Image>().color = ActiveAvatarColor;

        CurrentAvatar.sprite = ItemList[newSelectedIndex].Image;
    }
}
