using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentGold = 32;
    private void Start()
    {
        Thievery();
    }

    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        } else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }
}
