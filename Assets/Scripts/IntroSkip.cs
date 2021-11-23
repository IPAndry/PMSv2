using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSkip : MonoBehaviour
{
    public GameObject imageNext;
    public GameObject imageThis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Skip()
    {
        imageNext.SetActive(true); 
        imageThis.SetActive(false);
    }
}
