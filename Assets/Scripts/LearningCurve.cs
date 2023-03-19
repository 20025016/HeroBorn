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

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        List<int> playerScores = new()
        {
            30, 45, 50
        };

        Debug.LogFormat("Number of scores: {0}", playerScores.Count);
    }
}