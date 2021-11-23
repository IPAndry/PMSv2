using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompanyLogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Whait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        
    }

    IEnumerator Whait()
    {
        print(1);
        yield return new WaitForSeconds(5f);
        print(2);
        SceneManager.LoadScene("MainMenu");
    }
}
