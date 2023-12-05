using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class Water : MonoBehaviour
{
    public Animator anim;

    bool bOnWater = false;
    bool bOnWaterCheck = false;
    bool bKeyCheck = false;

    float currentTime = 0.0f;
    float maxTime = 0.01f;
    float speed = 1.0f;
    public GameObject waterPrefab;
    public Transform waterPosition;
    GameObject water;

    [SerializeField] AudioSource audio;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        KeyInput();

        if (bOnWater == true)
            RunningWaterFunc();

    }

    int count = 0;

    void KeyInput()
    {
        if (Input.GetButtonDown("XRI_Left_TriggerButton") && bOnWater == true && bKeyCheck == true)
        {
            bOnWater = false;
            audio.Stop();
            count = 0;

        }
        else if (Input.GetButtonDown("XRI_Left_TriggerButton") && bOnWater == false && bKeyCheck == true)
        {
            bOnWaterCheck = true;
            bOnWater = true;
            count++;
            if(count == 1)
            {
                audio.Play();
            }

        }
        else if (Input.GetButtonDown("XRI_Right_TriggerButton") && bOnWater == true && bKeyCheck == true)
        {
            bOnWater = false;
            audio.Stop();
            count = 0;
        }
        else if (Input.GetButtonDown("XRI_Right_TriggerButton") && bOnWater == false && bKeyCheck == true)
        {
            bOnWater = true;
            bOnWaterCheck = true;
            count++;
            if (count == 1)
            {
                audio.Play();
            }
        }



    }

    void WaterSpawn()
    {
        water = Instantiate(waterPrefab);
        water.transform.position = waterPosition.position;

    }

    void RunningWaterFunc()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            WaterSpawn();
            currentTime = 0.0f;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        bKeyCheck = true;

        if (bOnWater == true && bOnWaterCheck == true)
        {
            anim.SetBool("On", false);
            
        }
        else if (bOnWater == false && bOnWaterCheck == true)
        {
            anim.SetBool("On", true);
        }


    }
    private void OnTriggerExit(Collider other)
    {
        bKeyCheck = false;

    }

}
