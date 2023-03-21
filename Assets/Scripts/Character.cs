using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Exp = 0;

    public Character()
    {
        Name = "not assigned";
    }

    public Character(string name)
    {
        this.Name = name;
    }
}