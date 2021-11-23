using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveTimer : MonoBehaviour
{
    public GameObject gameObject;
    public float setTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(setTime);
        gameObject.SetActive(true);
    }
}
