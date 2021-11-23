using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameme : MonoBehaviour
{
    #region SIngleton:Game

    public static Gameme Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    [SerializeField] Text[] allCoinsUIText;

    int playerMoneys;

    int Coins;

    int minus;

    private void Update()
    {
        playerMoneys = PlayerPrefs.GetInt("PlayerMoney");
        Coins = playerMoneys;
        UpdateAllCoinsUIText();

        print("PlayerMoneys" + playerMoneys);
        print("Minus" + minus);
    }

    private void Start()
    {
        //PlayerPrefs.SetInt("PlayerMoney", 100000000);
        playerMoneys = PlayerPrefs.GetInt("PlayerMoney");
        Coins = playerMoneys;
        UpdateAllCoinsUIText();
    }

    public void UseCoins(int amount)
    {
        Coins -= amount;
        minus = Coins - (amount * (1/2)); // Почему?
        PlayerPrefs.SetInt("PlayerMoney", minus);
    }

    public bool HasEnoughCoins(int amount)
    {
        return (Coins >= amount);
    }

    public void UpdateAllCoinsUIText()
    {
        for (int i = 0; i < allCoinsUIText.Length; i++)
        {
            allCoinsUIText[i].text = Coins.ToString();
        }
    }
}
