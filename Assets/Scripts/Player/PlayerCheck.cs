using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCheck : MonoBehaviour
{
    [SerializeField] private Text allMoney;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //print(PlayerPrefs.HasKey("PlayerMoney"));
        int money = PlayerPrefs.GetInt("PlayerMoney");
        allMoney.text = money.ToString();
    }
}
