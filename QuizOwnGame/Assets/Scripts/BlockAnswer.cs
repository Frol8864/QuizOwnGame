using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;
public class BlockAnswer : MonoBehaviour
{
    [SerializeField] Text namePlayer;
    [SerializeField] List<ButtonScore> buttonScores;
    private Player player;
    private int valueChangeScore;
    private bool isAct;

    public void StartAnswer(Player _player, int scoreWin, int scoreTry, int scoreLose){
        buttonScores[0].StartAnswer(scoreLose, true);
        buttonScores[1].StartAnswer(scoreTry, false);
        buttonScores[2].StartAnswer(scoreWin, false);
        ChangeValueScore(scoreLose);
        player = _player;
        namePlayer.GetComponent<Text>().text = player.namePlayer;
        isAct = true;
    }

    public void ChangeValueScore(int _valueChangeScore){
        valueChangeScore = _valueChangeScore;
    }

    public void Clear(){
        namePlayer.GetComponent<Text>().text = "";
        DeactiveButton();
        for(int i = 0; i < buttonScores.Count; i++) {
            buttonScores[i].StartAnswer(0, false);
        }
        isAct = false;
        player = null;
    }

    public void DeactiveButton(){
        for(int i = 0; i < buttonScores.Count; i++) {
            buttonScores[i].isAct = false;
            buttonScores[i].OnMouseExit();
        }
    }

    public void CalculateScore(){
        if(!isAct) return;
        player.scoreValue += valueChangeScore;
    }
}
