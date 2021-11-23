using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelationsBar : MonoBehaviour
{
    public Slider slider;


    void Update()
    {
        print(PlayerPrefs.HasKey("SaberSympathy"));

        int sympathy = PlayerPrefs.GetInt("SaberSympathy");

        SetRelations(sympathy);
    }

    public void SetRelations(int sympathy)
    {
        slider.value = sympathy;
    }
}
