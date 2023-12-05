using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderRotation : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Camera mainCam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camRot = new Vector3(-mainCam.transform.rotation.x, -mainCam.transform.rotation.y, -mainCam.transform.rotation.z);

        transform.rotation = Quaternion.Euler(camRot);

    }
}
