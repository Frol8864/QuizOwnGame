using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class PanelQuestion : MonoBehaviour
{
    [SerializeField] Text textQuestion;
    [SerializeField] List<BlockAnswer> blockAnswers;
    [SerializeField] GameObject panel;
    [SerializeField] ContGame contGame;

    public bool isAnswer = false;
    private Question question;

    public void StartAnswer(Question _question, List<Player> players){
        panel.SetActive(true);
        isAnswer = true;
        question = _question;
        textQuestion.GetComponent<Text>().text = question.text;
        for(int i = 0; i < blockAnswers.Count; i++) {
            blockAnswers[i].Clear();
        }
        for(int i = 0; i < players.Count; i++) {
            if(i < 3){
                blockAnswers[i].StartAnswer(players[i], 
                question.scoreWinMain, question.scoreTryMain, question.scoreLoseMain);
                players[i].countRound++;
            } else {
                blockAnswers[i].StartAnswer(players[i], 
                question.scoreWinNoMain, question.scoreTryNoMain, question.scoreLoseNoMain);
            }
        }
    }

    public void CalculateScore(){
        for(int i = 0; i < blockAnswers.Count; i++) {
            blockAnswers[i].CalculateScore();
        }
        contGame.StartNewRound();
        isAnswer = false;
        panel.SetActive(false);
    }
}
