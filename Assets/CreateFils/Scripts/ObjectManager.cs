using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject nonWaterTowel;
    public GameObject waterTowel;

    bool check = false;
    bool objectCheck = false;

    public bool getCheck { get { return check; } }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Water")
        {
            nonWaterTowel.SetActive(false);
            waterTowel.SetActive(true);
            check = true;
        }
        //if(other.CompareTag("HandCollider"))
        //{
        //    objectCheck = true;
        //}

    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("HandCollider"))
        //{
        //    objectCheck = false;
        //}

    }

}
