using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        FindPartyMember();
    }

    public void FindPartyMember()
    {
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        int questPartySize = questPartyMembers.Count;

        Debug.LogFormat("Quest Party Size: {0}", questPartySize);
        for (int i = 0; i < questPartySize; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);
            if (questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }
}