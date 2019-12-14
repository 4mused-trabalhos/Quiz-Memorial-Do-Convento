using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Answer_Manager : MonoBehaviour {

    public int Score = 0;
    public GameObject[] Questions;
    private int CurQuestion = 0;

    public GameObject Right_Bell;
    public GameObject Wrong_Buzzer;
    public GameObject EndScreen;

    public GameObject TextHolder;
    public TextMeshProUGUI Text;
 
    void Start() {

            Questions = GameObject.FindGameObjectsWithTag("Question");

            foreach(GameObject Q in Questions)
            {
                Q.SetActive(false);
            }

            Questions[CurQuestion].SetActive(true);

            Text = TextHolder.GetComponent<TextMeshProUGUI>();
            Text.text = "Corretas: " + Score + "/16";

    }

    public void _Right() {

        Score += 1;
        ChangeQuestion();
        Right_Bell.SetActive(true);

    }

    public void _Wrong() {

        ChangeQuestion();
        Wrong_Buzzer.SetActive(true);

    }

    void ChangeQuestion() {

        Questions[CurQuestion].SetActive(false);
        CurQuestion += 1;

        if(CurQuestion < Questions.Length) {
            Questions[CurQuestion].SetActive(true);
            
        }
        else {
            //Adicionar menu final
            EndScreen.SetActive(true);
        }

        Text.text = "Corretas: " + Score + "/16";

    }

}