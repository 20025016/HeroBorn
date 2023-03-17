using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    public int MaxPlayerHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        int myInteger = 3;
        float myFloat = myInteger;

        Debug.Log(myInteger);
        Debug.Log(myFloat);

        int explicitConversion = (int)3.14;
        Debug.Log(explicitConversion);

        var currentAge = 32;
        Debug.Log(currentAge);
    }

    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
