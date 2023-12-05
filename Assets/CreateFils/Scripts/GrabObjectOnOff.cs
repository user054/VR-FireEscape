using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjectOnOff : MonoBehaviour
{
    [SerializeField] GameObject OnObject;
    [SerializeField] GameObject OffObject;

    public void ObjectOnOff()
    {
        OnObject.SetActive(true);
        OffObject.SetActive(false);
    }
}
