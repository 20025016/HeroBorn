using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool HasDungeonKey = false;
    public string WeaponType = "Arcane Staff";
    private void Start()
    {
        if (!HasDungeonKey)
        {
            Debug.Log("You may not enter without the sacred key.");
        } 
        
        if (WeaponType != "Longsword")
        {
            Debug.Log("You don't appear to have the right type of weapon...");
        }
    }
}
