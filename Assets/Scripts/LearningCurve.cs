using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        Character hero = new Character();
        Character villain = hero;
        villain.Name = "Sir Kane the Bold";

        hero.PrintStatsInfo();
        villain.PrintStatsInfo();
    }
}