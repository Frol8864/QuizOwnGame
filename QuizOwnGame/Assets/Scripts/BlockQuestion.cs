using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class BlockQuestion : MonoBehaviour
{
    [SerializeField] PanelQuestion panelQuestion;
    //[SerializeField] TableScorePlayers tableScorePlayers;
    [SerializeField] TableQuestions tableQuestions;
    [SerializeField] GameObject frameFon;
    [SerializeField] Text text;
    private Question question;
    private bool isAct;

    public void StartNewGame(Question _question){
        question = _question;
        isAct = true;
        text.GetComponent<Text>().text = question.scoreWinMain.ToString();
    }

    private void OnMouseEnter() {
        if(!isAct) return;
        frameFon.GetComponent<Image>().color = new Color(1, 0.92f, 0.016f, 1);
    }

    private void OnMouseExit() {
        if(!isAct) return;
        frameFon.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }

    private void OnMouseDown() {
        if(!isAct || panelQuestion.isAnswer) return;
        isAct = false;
        frameFon.GetComponent<Image>().color = new Color(1, 0, 0, 1);
        
        panelQuestion.StartAnswer(question, tableQuestions.players);
    }
}
