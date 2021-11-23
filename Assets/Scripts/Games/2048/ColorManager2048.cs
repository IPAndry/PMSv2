using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager2048 : MonoBehaviour
{
    public static ColorManager2048 Instance;

    public Color[] CellColors;

    [Space(5)]
    public Color PointsDarkColor;
    public Color PointsLightColor;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}
