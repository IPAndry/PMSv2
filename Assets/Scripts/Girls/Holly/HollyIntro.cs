using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HollyIntro : MonoBehaviour
{
    public int hollyClicking;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hollyClicking >= 20)
        {
            PlayerPrefs.SetInt("HollyDeath", 0);
            PlayerPrefs.Save();
        }
        else
        {            
            PlayerPrefs.SetInt("HollyDeath", 1);
            PlayerPrefs.Save();
        }

        print(PlayerPrefs.GetInt("HollyDeath"));
    }

    public void HollyClicking()
    {
        hollyClicking++;
    }
}
