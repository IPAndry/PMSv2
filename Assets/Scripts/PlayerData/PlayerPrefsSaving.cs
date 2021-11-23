using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaving : MonoBehaviour
{
    public string intName;
    public int intValue;

    private void Start()
    {
        SaveGame();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt(intName, intValue);
        PlayerPrefs.Save();
    }
}
