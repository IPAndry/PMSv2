using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoneyChecker : MonoBehaviour
{
    [SerializeField] Text playerMoney;

    // Update is called once per frame
    void Update()
    {
        playerMoney.text = PlayerPrefs.GetInt("PlayerMoney").ToString();
    }
}
