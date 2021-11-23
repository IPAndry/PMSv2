using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllItems : MonoBehaviour
{
    public int id;
    string names;
    string description;

    public Text textName;
    public Text textDesc;

    [SerializeField] Image imageHolder;
    [SerializeField] Sprite[] image;

    [SerializeField] GameObject[] Item;


    private void Start()
    {
        for (int i = 0; i < InventorySystem.itemChecker.Length; i++)
        {
            BadItemDataBase(i);
            //textName.text = names;
            //textDesc.text = description;
        }


    }

    public void BadItemDataBase(int id)
    {
        switch (id)
        {
            case 1:
                names = "Попит";
                description = "Idi nahui";
                imageHolder.sprite = image[0];
                break;
            case 2:
                names = "FSAfasf";
                description = "Idasafasfasi nahui";
                imageHolder.sprite = image[1];
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            default:
                break;
        }
    }
}
