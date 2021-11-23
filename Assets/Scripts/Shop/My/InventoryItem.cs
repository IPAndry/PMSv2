using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public int itemNumberInGrid;

    [SerializeField] Image imageHolder;

    public InventorySystem inventorySystems;

    private void Update()
    {
        int prefsItem = PlayerPrefs.GetInt($"Item{itemNumberInGrid}");
        imageHolder.sprite = inventorySystems.image[prefsItem];
    }

    public void DeleteItem()
    {
        if (PlayerPrefs.GetInt($"Item{itemNumberInGrid}") != 0)
        {
            int inventoryCheck = PlayerPrefs.GetInt("PlayerInventory");
            PlayerPrefs.SetInt("PlayerInventory", inventoryCheck - 1);
            PlayerPrefs.SetInt($"Item{itemNumberInGrid}", 0);
            PlayerPrefs.Save();
        }
    }
}
