using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navi_3 : MonoBehaviour
{
    [SerializeField] HandColliderCheck handCheck;
    [SerializeField] GameObject nextNaviBar;

    bool check = false;


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
        if (check == true)
        {
            NaviBarOnOff();

        }

    }



}
