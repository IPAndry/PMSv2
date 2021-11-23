using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] string shopItemName;
 
    [Tooltip("ID shop item")]
    [SerializeField] int itemID;

    [SerializeField] Text textCostField;

    [SerializeField] GameObject window;

    int itemCost;
    int checkPlayerInv;

    private void Start()
    {
        PlayerPrefs.SetInt("PlayerMoney", 1000000);

        itemCost = Convert.ToInt32(textCostField.text);
    }

    private void Update()
    {
        checkPlayerInv = PlayerPrefs.GetInt("PlayerInventory");

        print("Inventory" + PlayerPrefs.GetInt("PlayerInventory"));
        print("Money" + PlayerPrefs.GetInt("PlayerMoney"));
    }

    public void BuyItem()
    {
        window.GetComponent<UIOnTop>().BuyItemClick(itemID, itemCost);

        //UIOnTop uIOnTop = new UIOnTop();
        //uIOnTop.BuyItemClick(itemID, itemCost);

        //int checkPlayerMoney = PlayerPrefs.GetInt("PlayerMoney");

        //if (checkPlayerInv == 10)
        //{
        //    print("inventory full!");
        //}
        //else if (checkPlayerMoney < itemCost)
        //{
        //    print("no money!");
        //}
        //else
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (PlayerPrefs.GetInt($"Item{i}") == 0)
        //        {
        //            PlayerPrefs.SetInt($"Item{i}", itemID);
        //            break;
        //        }

        //    }

        //    // Увеличение значения заполнености инвентаря на 1
        //    PlayerPrefs.SetInt("PlayerInventory", ++checkPlayerInv);

        //    // Отнятие от денег игрока суммы покупки
        //    PlayerPrefs.SetInt("PlayerMoney", checkPlayerMoney -= itemCost);

        //    //int itemAmount = PlayerPrefs.GetInt($"Item+{itemPPName}");
        //    //PlayerPrefs.SetInt($"Item+{itemPPName}", ++itemAmount);
        //    PlayerPrefs.Save();

        //    window.SetActive(false);

        //}
    }

    //public void BuyItem()
    //{
    //    int checkPlayerMoney = PlayerPrefs.GetInt("PlayerMoney");

    //    if (checkPlayerInv == 10)
    //    {
    //        print("inventory full!");
    //    }
    //    else if (checkPlayerMoney < itemCost)
    //    {
    //        print("no money!");
    //    }
    //    else
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            if (PlayerPrefs.GetInt($"Item{i}") == 0)
    //            {
    //                PlayerPrefs.SetInt($"Item{i}", itemID);
    //                break;
    //            }

    //        }

    //        // Увеличение значения заполнености инвентаря на 1
    //        PlayerPrefs.SetInt("PlayerInventory", ++checkPlayerInv);

    //        // Отнятие от денег игрока суммы покупки
    //        PlayerPrefs.SetInt("PlayerMoney", checkPlayerMoney -= itemCost);

    //        //int itemAmount = PlayerPrefs.GetInt($"Item+{itemPPName}");
    //        //PlayerPrefs.SetInt($"Item+{itemPPName}", ++itemAmount);
    //        PlayerPrefs.Save();

    //        window.SetActive(false);

    //    }
    //}

    public void CancelBuy()
    {
        window.SetActive(false);
    }

    public void StartBuy()
    {
        window.SetActive(true);
    }



}
