using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeDiplayMgr : MonoBehaviour
{
    [SerializeField] GameObject image;
    [SerializeField] float fadeSpeed = 0.01f;
    void Start()
    {
        image.GetComponent<FadeInOut>().DisplayFadeInOutController(1, 1.0f, 0.0f, -fadeSpeed);
        print("üũ");
    }



}
