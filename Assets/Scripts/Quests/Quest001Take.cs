using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is handling the notice board.  making it work on Action button and on mouse hover.
/// </summary>
public class Quest001Take : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);


            if (Input.GetButtonDown("Action")) //we need to put what ever we put in our inout setting in unity
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                ActionDisplay.SetActive(false); //turn it off because we picked up the notice
                ActionText.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true); //turn new cam on before we turn of the player
                ThePlayer.SetActive(false);

            }
        }

    }
        void OnMouseExit() //the 
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
        }
}
