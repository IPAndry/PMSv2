using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOnTop : MonoBehaviour
{
    int checkPlayerInv;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerInv = PlayerPrefs.GetInt("PlayerInventory");
    }

    public void BuyItemClick(int itemID, int itemCost)
    {
        int checkPlayerMoney = PlayerPrefs.GetInt("PlayerMoney");

        if (checkPlayerInv == 10)
        {
            print("inventory full!");
        }
        else if (checkPlayerMoney < itemCost)
        {
            print("no money!");
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                if (PlayerPrefs.GetInt($"Item{i}") == 0)
                {
                    PlayerPrefs.SetInt($"Item{i}", itemID);
                    break;
                }

            }

            // Увеличение значения заполнености инвентаря на 1
            PlayerPrefs.SetInt("PlayerInventory", ++checkPlayerInv);

            // Отнятие от денег игрока суммы покупки
            PlayerPrefs.SetInt("PlayerMoney", checkPlayerMoney -= itemCost);

            //int itemAmount = PlayerPrefs.GetInt($"Item+{itemPPName}");
            //PlayerPrefs.SetInt($"Item+{itemPPName}", ++itemAmount);
            PlayerPrefs.Save();

        }
    }

    public void CancelBuyClick()
    {

    }
}
