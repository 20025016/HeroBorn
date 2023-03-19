using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Two dimensional array
    private int[,] Coordinates2d = new int[3, 2]
    {
        { 5, 4 },
        { 1, 7 },
        { 9, 3 }
    };

    // Three dimensional array
    private int[,,] Coordinates3d = new int[3, 3, 2]
    {
        { { 1, 2 }, { 3, 4 }, { 5, 6 } },
        { { 7, 8 }, { 9, 10 }, { 11, 12 } },
        { { 13, 14 }, { 15, 16 }, { 17, 18 } },
    };

    private void Start()
    {
        /*
         * First row, first column
         * Value is 4
         */
        int coordinateValue = Coordinates2d[0, 1];
        Debug.Log(coordinateValue);

        /*
         * First row, first column
         * Value is now set to 10
         */
        Coordinates2d[0, 1] = 10;
        coordinateValue = Coordinates2d[0, 1];
        Debug.Log(coordinateValue);

        /*
         * Second row, third column, second element
         * Value is 12
         */
        Debug.Log(Coordinates3d[1, 2, 1]);
    }
}
