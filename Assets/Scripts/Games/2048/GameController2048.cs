using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController2048 : MonoBehaviour
{
    public static GameController2048 Instance;

    public static int Points { get; private set; }

    public static bool GameStarted { get; private set; }

    [SerializeField] private Text gameResult;
    [SerializeField] private GameObject gameResultBack;

    [SerializeField] private TextMeshProUGUI pointsText;

    [SerializeField] private Text allMoney;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        StartGame();
    }

    private void Update()
    {
        print("point = " + Points);
        int money = PlayerPrefs.GetInt("PlayerMoney");
        allMoney.text = money.ToString();
    }

    public void StartGame()
    {
        gameResult.text = "";

        SetPoints(0);
        GameStarted = true;

        Field2048.Instance.GenerateField();
    }

    public void Win()
    {
        GameStarted = false;
        gameResultBack.SetActive(true);
        gameResult.text = "Великолепная работа!";
        //PlayerController.playerMoney += Points;

        int money = PlayerPrefs.GetInt("PlayerMoney");
        money += Points;
        PlayerPrefs.SetInt("PlayerMoney", money);

        PlayerPrefs.Save();

    }

    public void Lose()
    {
        GameStarted = false;
        gameResultBack.SetActive(true);
        gameResult.text = "Рабочий день окончен!";
        //PlayerController.playerMoney += Points;

        int money = PlayerPrefs.GetInt("PlayerMoney");
        money += Points;
        PlayerPrefs.SetInt("PlayerMoney", money);

        PlayerPrefs.Save();
    }

    public void AddPoints(int points)
    {
        SetPoints(Points + points);
    }

    private void SetPoints(int points)
    {
        Points = points;
        pointsText.text = Points.ToString();
    }

}
