using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navi_2 : MonoBehaviour
{
    [SerializeField] ObjectManager objectCheck;
    [SerializeField] GameObject nextNaviBar;

    bool check = false;


    private void Update()
    {
        ObjectCheck();
        Action();

    }

    void ObjectCheck()
    {
        check = objectCheck.getCheck;
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
