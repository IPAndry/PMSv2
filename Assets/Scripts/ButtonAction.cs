using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public string sceneName;
    public GameObject gameObject;

    public void LoadScene()
    {
        StartCoroutine(Wait());
        SceneManager.LoadScene(sceneName);
    }

    public void ShowObject()
    {
        gameObject.SetActive(true);
    }
    public void HideObject()
    {
        gameObject.SetActive(false);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
    }
}
