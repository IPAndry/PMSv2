using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    Scene m_Scene;

    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        PlayerController.currentScene = m_Scene.name;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
