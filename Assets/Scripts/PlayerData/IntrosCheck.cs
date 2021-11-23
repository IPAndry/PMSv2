using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntrosCheck : MonoBehaviour
{
    public string variableName;

    public string introScene;
    public string girlScene;

    private void OnMouseDown()
    {
        CheckIntro();
    }

    public void CheckIntro()
    {
        int intValue = PlayerPrefs.GetInt(variableName);
        if (intValue == 0)
        {
            SceneManager.LoadScene(introScene);
        }
        else
        {
            SceneManager.LoadScene(girlScene);
        }
    }

}
