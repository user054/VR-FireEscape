using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class WaterMove : MonoBehaviour
{
    float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * -transform.up * Time.deltaTime;
        Destroy(gameObject, 0.5f);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Destroy(gameObject);
    //}

}
