using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }
}
