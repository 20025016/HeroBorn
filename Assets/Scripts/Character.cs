using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Exp = 0;

    public Character()
    {
        Reset();
    }

    public Character(string name)
    {
        this.Name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.Name, this.Exp);
    }

    private void Reset()
    {
        this.Name = "Not assigned";
        this.Exp = 0;
    }
}