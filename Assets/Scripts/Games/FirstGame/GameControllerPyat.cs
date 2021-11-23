using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerPyat : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    void Start()
    {
        Rotate();
        winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        Win();
    }

    void Rotate()
    {
        pictures[0].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
        pictures[1].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
        pictures[2].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
        pictures[3].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
        pictures[4].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
        pictures[5].transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 3) * 90);
    }

    void Win()
    {
        if (
           pictures[0].rotation.z <= 0.09 &&
           pictures[1].rotation.z <= 0.09 &&
           pictures[2].rotation.z <= 0.09 &&
           pictures[3].rotation.z <= 0.09 &&
           pictures[4].rotation.z <= 0.09 &&
           pictures[5].rotation.z <= 0.09
           )
        {
            print("Opa");
            winText.SetActive(true);
            youWin = true;
        }
    }
}
