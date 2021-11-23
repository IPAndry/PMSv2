using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Деньги игрока
    public static int playerMoney;
    // Текущая сцена
    public static string currentScene;

    public Text moneyText;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        playerMoney = data.money;
        currentScene = data.scene;
    }
    public void NullPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        playerMoney = 0;
        SceneManager.LoadScene("PreIntro");
        SaveSystem.SavePlayer(this);
    }




    void Update()
    {
        moneyText.text = playerMoney.ToString();
    }
}
