using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject Object;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Object.SetActive (true);
        }
        
        else
        {
            Object.SetActive (false);
        }
    }
}
