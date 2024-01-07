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

    private void Start() {
        tableScorePlayers.StartNewGame();
        tableQuestions.StartNewGame();
    }

    public void StartNewRound(){
        tableQuestions.StartNewRound();
        //tableScorePlayers.UpdateShow();
    }
}
