using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class TableQuestions : MonoBehaviour
{
    [SerializeField] TableScorePlayers tableScorePlayers;
    [SerializeField] List<BlockQuestion> blockQuestions;
    [SerializeField] LibraryQuestion libraryQuestion;

    public List<Player> players;

    public void StartNewGame(){
        StartNewRound();
        List<Question> questions = libraryQuestion.GetQuestions();
        for(int i = 0; i < blockQuestions.Count; i++) {
            blockQuestions[i].StartNewGame(questions[i]);
        }
    }
    public void StartNewRound(){
        tableScorePlayers.SortBlockPlayers();
        players = tableScorePlayers.GetPlayers();
        players[0].isTurn = true;
        tableScorePlayers.UpdateShow();
    }
}
