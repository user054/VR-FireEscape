using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionStay(Collision collision)
    {
        //if(collision.gameObject.tag == "Object")
        //{
        //    print("xx");
        //}
        print("xx");
    }

    private void OnTriggerStay(Collider other)
    {

        print("xx");
    }


}
