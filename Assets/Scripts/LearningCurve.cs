using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("\"Choose\" a character.");
        GenerateCharacter();
        Debug.Log("A fine choice.");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateCharacter()
    {
        Debug.Log("Character: Spike");
    }
}
