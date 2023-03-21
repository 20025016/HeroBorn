using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private void Start()
    {
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;

        warBow.Name = "War Bow";
        warBow.Damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }
}