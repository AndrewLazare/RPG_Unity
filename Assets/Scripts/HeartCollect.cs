using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    // Start is called before the first frame update. Dont need it hear though

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject ThisHeart;

    // Update is called once per frame.  We want this to be called all the time in this game,  thats why we didnt use start.
    void Update()
    {
        RotateSpeed = 4;
        transform.Rotate(0, RotateSpeed, 0, Space.World);  
    }
    void OnTriggerEnter() //This is where we collect our heart
    {
        CollectSound.Play();
        HeathMonitor.HealthValue += 1;
        ThisHeart.SetActive(false);
    }
}
