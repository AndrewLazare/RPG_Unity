using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Q001_Objective001 : MonoBehaviour
{
    public GameObject TheObjective;
    public int CloseObjective;

    /// <summary>
    /// This update is to make it shrink, clear for good to say weve completed quest.
    /// </summary>
    void Update()
    {
        if (CloseObjective == 1)//like below
        {
            if (TheObjective.transform.localScale.y <= 0.0f)
            {
                CloseObjective = 0;//this objective is now complete so it now it equals 0 and we are setting it inactive.
                TheObjective.SetActive(false);
            }
            else// we want to shrink our UI element about 0.01 on frame
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }

    }
    void OnTriggerEnter()
    {
        StartCoroutine(FinishObjective());
    }
    IEnumerator FinishObjective()
    {
        TheObjective.SetActive(true); //this is inactive on UI
        yield return new WaitForSeconds(0.5f); //Half sec of anim to fade onto screen
        CloseObjective = 1; //It's set to 0 by default.  its the first one.
    }
}
