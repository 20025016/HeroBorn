using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        Character hero = new Character();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Paladin knight = new Paladin("Sir Arthur");
        knight.PrintStatsInfo();
    }
}