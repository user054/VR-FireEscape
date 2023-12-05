using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class Navi_1 : MonoBehaviour
{
    [SerializeField] HandColliderCheck handCheck;
    [SerializeField] GameObject nextNaviBar;

    [SerializeField] AudioSource audio;

    //[SerializeField] GameObject postProcess;

    int count = 0;



    bool check = false;

    private void Start()
    {
        //postProcessVignette = postProcessVolume.GetComponent<Vignette>();
        //print(postProcessVolume.GetPrefabDefinition<Vignette>());

    }

    private void Update()
    {
        GetHandCheck();
        Action();
    }

    void GetHandCheck()
    {
        check = handCheck.getColliderCheck;
    }

    void NaviBarOnOff()
    {
        gameObject.SetActive(false);
        nextNaviBar.SetActive(true);
    }


    void Action()
    {
        if(check == true)
        {
            if(count== 0)
            {
                Audio();
                count++;
                StartCoroutine(NaviCoroutine());
            }
        }

    }

    IEnumerator NaviCoroutine()
    {
        yield return new WaitForSeconds(0.7f);
        NaviBarOnOff();


    }


    void Audio()
    {
        audio.Play();

    }


}
