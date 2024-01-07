using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;
public class BlockPlayer : MonoBehaviour
{
    [SerializeField] Text namePlayer;
    [SerializeField] Text score;
    [SerializeField] GameObject frameFon;
    [SerializeField] GameObject status;
    [SerializeField] Sprite fire;
    [SerializeField] Sprite shit;
    [SerializeField] TableScorePlayers tableScorePlayers;

    public Player player;

    public void StartNewGame(){
        player = new Player(namePlayer.GetComponent<Text>().text);
        UpdateShow();
    }

    public void UpdatePlayer(Player _player){
        player = _player;
        UpdateShow();
    }

    private void OnMouseEnter() {
        frameFon.GetComponent<Image>().color = new Color(1, 0.92f, 0.016f, 1);
    }

    private void OnMouseExit() {
        ChangeStatus();
    }

    private void OnMouseDown() {
        player.isPlay = !player.isPlay;
        ChangeStatus();
        OnMouseEnter();
        tableScorePlayers.SortBlockPlayers();
    }

    public void UpdateShow(){
        namePlayer.GetComponent<Text>().text = player.namePlayer;
        score.GetComponent<Text>().text = player.scoreValue.ToString();
        ChangeStatus();
    }

    private void ChangeStatus(){
        status.GetComponent<Image>().sprite = player.isPlay ? fire : shit;
        frameFon.GetComponent<Image>().color = player.isPlay ? 
                                                (player.isTurn ? new Color(0,1,0,1) : new Color(1,1,1,1)) 
                                                            : new Color(1,0,0,1);
    }
}

public class Player{
    public string namePlayer;
    public int scoreValue;
    public int countRound;
    public int countWinRound;
    public bool isPlay;
    public bool isTurn;

    public Player(string _namePlayer){
        namePlayer = _namePlayer;
        scoreValue = 0;
        countRound = 0;
        countWinRound = 0;
        isPlay = true;
        isTurn = false;
    }
}
