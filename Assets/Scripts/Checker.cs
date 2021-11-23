using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject ShowPhoto;

    public GameObject other;
    
    public GameObject otther5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.score >= 255)
        {
            ShowPhoto.SetActive(true);
            other.SetActive(false);
            otther5.SetActive(true);
            
        }
    }
}
