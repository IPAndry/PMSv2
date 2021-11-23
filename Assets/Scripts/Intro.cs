using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartImage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartImage()
    {
        yield return new WaitForSeconds(10f);
        this.gameObject.SetActive(false);
        image.SetActive(true);
    }
}
