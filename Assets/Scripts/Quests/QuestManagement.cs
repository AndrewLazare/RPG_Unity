using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManagement : MonoBehaviour
{
    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    private void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
    }

}
