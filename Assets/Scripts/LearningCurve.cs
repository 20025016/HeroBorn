using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool WeaponEquipped = true;
    public string WeaponType = "Longsword";
    private void Start()
    {
        if (WeaponEquipped)
        {
            if (WeaponType == "Longsword")
            {
                Debug.Log("For the queen!");
            }
        }
        else
        {
            Debug.Log("Fists aren't going to work against armour...");
        }
    }
}
