using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsAction : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
