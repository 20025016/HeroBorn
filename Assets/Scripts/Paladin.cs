using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    public Weapon Weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.Weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.Name, this.Weapon.Name);
    }
}