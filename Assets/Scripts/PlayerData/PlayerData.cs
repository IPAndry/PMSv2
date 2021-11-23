using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int money;
    public string scene;

    public PlayerData (PlayerController playerData)
    {
        money = PlayerController.playerMoney;
        scene = PlayerController.currentScene;
    }

}
