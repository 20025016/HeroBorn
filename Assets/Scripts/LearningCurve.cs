using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.Name, hero.Exp);

        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.Name, heroine.Exp);
    }
}