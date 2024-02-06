using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;


public class Example : MonoBehaviour
{
    public Button b1, b2, b3, b4, b5, b6, b7, b8, b9, b0;

    public Button start;

    public int result = 0; 
    public TMP_Text numText;
    public TMP_Text inputText;
    public TMP_Text answerText;
    string output;

    bool newnum = true;
    bool startgame = false;

    int num = 0;
    int count = 0;

    int x = 0, y = 0;




    void Start()
    {
        b1.onClick.AddListener(() => TaskOnClick(1));
        b2.onClick.AddListener(() => TaskOnClick(2));
        b3.onClick.AddListener(() => TaskOnClick(3));
        b4.onClick.AddListener(() => TaskOnClick(4));
        b5.onClick.AddListener(() => TaskOnClick(5));
        b6.onClick.AddListener(() => TaskOnClick(6));
        b7.onClick.AddListener(() => TaskOnClick(7));
        b8.onClick.AddListener(() => TaskOnClick(8));
        b9.onClick.AddListener(() => TaskOnClick(9));
        b0.onClick.AddListener(() => TaskOnClick(0));

        start.onClick.AddListener(Start_Game);

    }


    void Update()
    {

        if (startgame)
        {

            if (newnum)
            {
                x = Random.Range(0, 13);
                y = Random.Range(0, 13);

                numText.SetText(x + "x" + y);

                newnum = false;

            }

        }

    }




    void Start_Game()
    {

        startgame = true;

    }




    void TaskOnClick(int input)
    {

        result = x * y;

        num = result.ToString().Length;

        count++;

        output = output + input;

        if (count >= num)
        {

            if (int.Parse(output) == result)
            {

                answerText.SetText("Correct");

                newnum = true;

                count = 0;

                output = "";

            }

            else
            {
                answerText.SetText("Incorrect");

                output = "";

                count = 0;

            }


        }




        inputText.SetText(output);

        Debug.Log("You have clicked the button!" + " " + num);
    }

}