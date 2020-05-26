using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathMonitor : MonoBehaviour
{
    public static int HealthValue; // this is static because we need to use this from a different script later
    public int EnternalHealth;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    void Start()
    {
        HealthValue = 1;
    }

   
    void Update()
    {
        EnternalHealth = HealthValue;

        if (HealthValue == 1)
        {
            Heart1.SetActive(true);
        }
        if (HealthValue == 2)
        {
            Heart2.SetActive(true);
        }
        if (HealthValue == 3)
        {
            Heart3.SetActive(true);
        }
    }
}
