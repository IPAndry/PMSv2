using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemImageSet : MonoBehaviour
{
    private int amountOfItem;
    public Text textCheck;

    [Tooltip("Image holder")]
    public Image imageHolder;

    [Tooltip("Sprite")]
    public Sprite[] image;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //print();
        //print();

        switch (textCheck.text)
        {
            case "�����":
                imageHolder.sprite = image[0];
                amountOfItem = PlayerPrefs.GetInt("AmountPopit");
                textCheck.text = "���-��: " + amountOfItem.ToString();
                break;
            case "�����":
                imageHolder.sprite = image[1];
                amountOfItem = PlayerPrefs.GetInt("AmountFlowers");
                textCheck.text = "���-��: " + amountOfItem.ToString();
                break;
            default:
                break;
        }
    }
}
