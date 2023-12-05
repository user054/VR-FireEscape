using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderCheck : MonoBehaviour
{
    bool check = false;

    public bool getColliderCheck { get { return check; } }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("HandCollider"))
        {
            check = true;   
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HandCollider"))
        {
            check = false;
        }
    }

}
