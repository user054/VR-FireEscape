using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MouthCol"))
        {
            Destroy(gameObject);

        }

    }



}
