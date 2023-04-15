using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"){
            Application.Quit();
        }
    }
}
