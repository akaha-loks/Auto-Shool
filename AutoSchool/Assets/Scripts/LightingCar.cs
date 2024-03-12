using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingCar : MonoBehaviour
{
    [SerializeField] private GameObject[] lights;
    [SerializeField] private string lightWhat;
    void Start()
    {
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        while (true)
        {
            switch (lightWhat)
            {
                case ("left"):
                    lights[0].SetActive(true);
                    lights[1].SetActive(true);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    break;
                case ("right"):
                    lights[3].SetActive(true);
                    lights[2].SetActive(true);
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    break;
                case ("none"):
                    lights[0].SetActive(false);
                    lights[1].SetActive(false);
                    lights[2].SetActive(false);
                    lights[3].SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }
}
