using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorUi : MonoBehaviour
{

    public HandColliderCheck handColliderCheck;
    public GameObject canvasOn;
    public GameObject canvasOff;
    
    [SerializeField] GameObject door;

    [SerializeField] SmokeMa smokeMa;

    bool check = false;

    // Update is called once per frame
    void Update()
    {
        if(handColliderCheck.getColliderCheck)
        {
            canvasOn.SetActive(true);
            canvasOff.SetActive(false);
            door.SetActive(false);
            check = true;
        }

        if(check == true)
        {
            smokeMa.StartSmoke();
        }

    }

}
