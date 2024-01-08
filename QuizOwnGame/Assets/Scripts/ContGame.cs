using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class ContGame : MonoBehaviour
{
    [SerializeField] TableScorePlayers tableScorePlayers;
    [SerializeField] TableQuestions tableQuestions;
    [SerializeField] PopUpWin popUpWin;

    private int countRound;

    private void Start() {
        countRound = 0;
        tableScorePlayers.StartNewGame();
        tableQuestions.StartNewGame();
    }

    private void Update() {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }

    public void StartNewRound(){
        tableQuestions.StartNewRound();
        //tableScorePlayers.UpdateShow();
        countRound++;
        if(countRound == 15) popUpWin.EndGame(tableScorePlayers.GetWin());
    }
}
