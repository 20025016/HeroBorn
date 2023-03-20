using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }
    }
}