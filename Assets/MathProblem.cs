using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MathProblem : MonoBehaviour
{
    
    public Text MathProblems;
    

    public static string[] problems = new string[] { "100/20", "50/10", "12/2", "10/1000" };

    // Update is called once per frame

    void Start()
    {
        int place = ButtonManager.Level;
        //Debug.Log(LevelC.cnt);
        MathProblems.text = problems[place - 1];

        


    }

    void Update()
    {
        
    }
}
