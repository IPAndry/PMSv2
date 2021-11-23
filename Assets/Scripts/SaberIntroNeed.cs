using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaberIntroNeed : MonoBehaviour
{
    // Start is called before the first frame update

    public string sceneName;

    public void LoadScene()
    {
        if (IntroCheck.checkedSaber == false)
        {
            StartCoroutine(Wait());
            SceneManager.LoadScene("SaberIntro");
        }
        else
        {
            StartCoroutine(Wait());
            SceneManager.LoadScene("Saber");
        }
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
    }
}
