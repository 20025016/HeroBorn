using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };

        Debug.LogFormat("Items: {0}", itemInventory.Count);

        int numberOfPotions = itemInventory["Potion"];

        itemInventory["Potion"] = 10;

        itemInventory.Add("Throwing Knife", 3);

        itemInventory["Bandage"] = 5;

        if (itemInventory.ContainsKey("Aspirin"))
        {
            itemInventory["Aspirin"] = 3;
        }

        itemInventory.Remove("Antidote");

        // Outputs 4
        Debug.LogFormat("Items: {0}", itemInventory.Count);
    }
}