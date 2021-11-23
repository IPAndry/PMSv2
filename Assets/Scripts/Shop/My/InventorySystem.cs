using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public int itemNumberInGrid;

    public static int[] itemChecker = new int[10];

    public GameObject Item;

    [SerializeField] Image imageHolder;

    public Sprite[] image;

    private void Update()
    {
        //print("item 1 " + itemChecker[0]);
        //print("item 2 " + itemChecker[1]);
        //print("item 3 " + itemChecker[2]);
        //print("item 4 " + itemChecker[3]);
        //print("item 5 " + itemChecker[4]);
        //print("item 6 " + itemChecker[5]);
        //print("item 7 " + itemChecker[6]);
        //print("item 8 " + itemChecker[7]);
        //print("item 9 " + itemChecker[8]);
        //print("item 10 " + itemChecker[9]);
    }
}
