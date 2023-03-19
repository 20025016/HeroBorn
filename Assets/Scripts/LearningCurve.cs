using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Empty array with default values
    private int[] Team1 = new int[3];
    // Longhand initialiser
    private int[] Team2 = new int[] { 713, 549, 984 };
    // Shorthand initialiser
    private int[] Team3 = { 713, 549, 984 };

    private void Start()
    {
        /*
         * Arrays zero index based
         * Team2[1] results in 549
         */
        Debug.Log(Team2[1]);
        /*
         * Modifying an element 
         * Team2[1] results in 550
         */
        Team2[1] = 550;
        Debug.Log(Team2[1]);
    }
}
