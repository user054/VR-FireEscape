using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testUI : MonoBehaviour
{

    public GameObject canvasOn;
    public float displayTime = 3f;
    int count = 0;


    private void OnTriggerEnter(Collider other)
    {
        count++;
        if(count == 1)
        {
            canvasOn.SetActive(true);
            Invoke("HideText", displayTime);
        }
        
    }
    private void HideText()
    {
        canvasOn.gameObject.SetActive(false);
    }

    
}
