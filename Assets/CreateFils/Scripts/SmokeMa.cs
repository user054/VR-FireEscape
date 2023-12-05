using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeMa : MonoBehaviour
{

    [SerializeField] Material ma;
    [SerializeField] float time = 0.01f;
    [SerializeField] ParticleSystem particleSystem1;
    [SerializeField] ParticleSystem particleSystem2;
    [SerializeField] ParticleSystem particleSystem3;
    [SerializeField] ParticleSystem particleSystem4;
    [SerializeField] ParticleSystem particleSystem5;
    [SerializeField] ParticleSystem particleSystem6;
    [SerializeField] ParticleSystem particleSystem7;
    [SerializeField] ParticleSystem particleSystem8;
    [SerializeField] ParticleSystem particleSystem9;
    [SerializeField] ParticleSystem particleSystem10;

    [SerializeField] float aColor = 0.5f;
    [SerializeField] float maxValue = 1.0f;

    float value = 0.0f;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Smoke(value));
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

    }

    public void StartSmoke()
    {
        if(count == 0)
        {
            StartCoroutine(Smoke(0.5f));
            count++;
            print("check");
        }
    }

    IEnumerator Smoke(float value)
    {
        while (aColor <= maxValue + value)
        {
            print(aColor);
            particleSystem1.startColor = new Color(255, 255, 255, aColor);
            particleSystem2.startColor = new Color(255, 255, 255, aColor);
            particleSystem3.startColor = new Color(255, 255, 255, aColor);
            particleSystem4.startColor = new Color(255, 255, 255, aColor);
            particleSystem5.startColor = new Color(255, 255, 255, aColor);
            particleSystem6.startColor = new Color(255, 255, 255, aColor);
            particleSystem7.startColor = new Color(255, 255, 255, aColor);
            particleSystem8.startColor = new Color(255, 255, 255, aColor);
            particleSystem9.startColor = new Color(255, 255, 255, aColor);
            particleSystem10.startColor = new Color(255, 255, 255, aColor);

            yield return new WaitForSeconds(0.1f);
            aColor += time;

        }


    }


}
