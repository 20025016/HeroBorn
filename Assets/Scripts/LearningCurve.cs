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

        questPartyMembers.Add("Craven the Necromancer");

        questPartyMembers.Insert(1, "Tanis the Thief");

        questPartyMembers.RemoveAt(0);
        //questPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        List<int> playerScores = new()
        {
            30, 45, 50
        };

        playerScores.Add(65);

        playerScores.Insert(1, 55);

        playerScores.Remove(45);

        Debug.LogFormat("Number of scores: {0}", playerScores.Count);
    }
}