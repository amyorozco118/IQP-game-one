using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public Button OptionOne;
    public Button OptionTwo;
    public Button OptionThree;

    public Text Problem1;
    public Text Problem2;
    public Text Problem3;


    string[,] options = new string[3, 3] { { "4", "5", "20" },
                                           { "2", "5", "8" }, { "2", "5", "84" } };

    string[] solutions = new string[] { "4", "5", "8" };


    public static int Level = 1;


    void updateOptions(int set)
    {
        Debug.Log("Updating");
        Problem1.text = options[Level - 1, 0];
        Problem2.text = options[Level - 1, 1];
        Problem3.text = options[Level - 1, 2];
    }
    public void ButtonMoveScene(int level)
    {
        string nextLevelName = "Level" + level;
        SceneManager.LoadScene(nextLevelName);

    }


    void Start()
    {
        updateOptions(Level - 1);
        OptionOne.onClick.AddListener(() =>
        {
            if(Problem1.text == solutions[Level - 1])
            {
                Score.AddPoint();
                Level++;
                string nextLevelName = "Level" + Level;
                SceneManager.LoadScene(nextLevelName);
            }

            
        });

        OptionTwo.onClick.AddListener(() =>
        {
            if (Problem2.text == solutions[Level - 1])
            {
                Score.AddPoint();
                Level++;
                string nextLevelName = "Level" + Level;
                SceneManager.LoadScene(nextLevelName);
            }
        });

        OptionThree.onClick.AddListener(() =>
        {
            Score.AddPoint();
            Level++;
            if (Problem1.text == solutions[Level - 1])
            {
                Level++;
                string nextLevelName = "Level" + Level;
                SceneManager.LoadScene(nextLevelName);
            }

        });
    }


    void Update()
    {
        //updateOptions(Level - 1);
    }

}
