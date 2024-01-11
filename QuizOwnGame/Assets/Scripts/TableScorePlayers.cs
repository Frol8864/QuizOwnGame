using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class TableScorePlayers : MonoBehaviour
{
    [SerializeField] List<BlockPlayer> blockPlayers;
    public void StartNewGame(){
        for(int i = 0; i < blockPlayers.Count; i++) {
            blockPlayers[i].StartNewGame();
        }
        blockPlayers[2].player.isPlay = false; //Валера не придет
    }

    public void UpdateShow(){
        for(int i = 0; i < blockPlayers.Count; i++) {
            blockPlayers[i].UpdateShow();
        }
    }

    public void SortBlockPlayers(){
        List<Player> players = new List<Player>();
        for(int i = 0; i < blockPlayers.Count; i++) {
            players.Add(blockPlayers[i].player);
        }
        SortPlayers(players);
        for(int i = 0; i < blockPlayers.Count; i++) {
            blockPlayers[i].UpdatePlayer(players[i]);
        }

    }

    public List<Player> GetPlayers(){
        List<PlayerStat> playerStats = new List<PlayerStat>();
        for(int i = 0; i < blockPlayers.Count; i++) {
            blockPlayers[i].player.isTurn = false;
            if(blockPlayers[i].player.isPlay)
                playerStats.Add(new PlayerStat(i, blockPlayers[i].player.scoreValue,
                             blockPlayers[i].player.countRound, blockPlayers[i].player.isPlay));
        }
        SortPlayerStats(playerStats);
        List<Player> players = new List<Player>();
        for(int i = 0; i < playerStats.Count; i++) {
            players.Add(blockPlayers[playerStats[i].id].player);
        }
        return players;
    }

    public string GetWin(){
        return blockPlayers[0].player.namePlayer;
    }

    private void SortPlayerStats(List<PlayerStat> playerStats){
        SwapRandomPlayerStats(playerStats);
        for(int i = 0; i < playerStats.Count; i++) {
            for(int j = i + 1; j < playerStats.Count; j++){
                if( (playerStats[i].countRound > playerStats[j].countRound) 
                || ((playerStats[i].countRound == playerStats[j].countRound) 
                    && (playerStats[i].scoreValue > playerStats[j].scoreValue)) ) {
                        SwapPlayerStats(playerStats[i], playerStats[j]);
                }
            }
        }
    }

    private void SwapPlayerStats(PlayerStat player1, PlayerStat player2){
        PlayerStat player0 = new PlayerStat(player1.id, player1.scoreValue, player1.countRound, player1.isPlay);

        player1.id = player2.id;
        player1.scoreValue= player2.scoreValue;
        player1.countRound = player2.countRound;
        player1.isPlay = player2.isPlay;

        player2.id = player0.id;
        player2.scoreValue= player0.scoreValue;
        player2.countRound = player0.countRound;
        player2.isPlay = player0.isPlay;
    }

    private void SwapRandomPlayerStats(List<PlayerStat> playerStats){
        for(int i = 0; i < 50; i++) {
            SwapPlayerStats(playerStats[Random.Range(0, playerStats.Count)],
                             playerStats[Random.Range(0, playerStats.Count)]);
        }
    }

    private void SortPlayers(List<Player> players){
        SwapRandomPlayers(players);
        for(int i = 0; i < players.Count; i++) {
            for(int j = i + 1; j < players.Count; j++){
                if(players[j].isPlay != players[i].isPlay){
                    if(players[j].isPlay && !players[i].isPlay)
                        SwapPlayers(players[i], players[j]);
                } else {
                    if( (players[j].scoreValue > players[i].scoreValue) || 
                        (players[j].scoreValue == players[i].scoreValue) && (
                            (players[j].countRound > players[i].countRound) 
                            || (players[j].countRound == players[i].countRound) && 
                                (players[j].countWinRound > players[i].countWinRound)
                        ) 
                    ) {
                            SwapPlayers(players[i], players[j]);
                        }
                }
            }
        }
    }

    private void SwapPlayers(Player player1, Player player2){
        Player player0 = new Player(player1.namePlayer);
        player0.countRound = player1.countRound;
        player0.countWinRound = player1.countWinRound;
        player0.isPlay = player1.isPlay;
        player0.isTurn = player1.isTurn;
        player0.scoreValue= player1.scoreValue;

        player1.namePlayer = player2.namePlayer;
        player1.countRound = player2.countRound;
        player1.countWinRound = player2.countWinRound;
        player1.isPlay = player2.isPlay;
        player1.isTurn = player2.isTurn;
        player1.scoreValue= player2.scoreValue;

        player2.namePlayer = player0.namePlayer;
        player2.countRound = player0.countRound;
        player2.countWinRound = player0.countWinRound;
        player2.isPlay = player0.isPlay;
        player2.isTurn = player0.isTurn;
        player2.scoreValue= player0.scoreValue;
    }

    private void SwapRandomPlayers(List<Player> players){
        for(int i = 0; i < 50; i++) {
            SwapPlayers(players[Random.Range(0, players.Count)],
                             players[Random.Range(0, players.Count)]);
        }
    }
}

public class PlayerStat{
    public int id;
    public int scoreValue;
    public int countRound;
    public bool isPlay;

    public PlayerStat(int _id, int _scoreValue, int _countRound, bool _isPlay){
        id = _id;
        scoreValue = _scoreValue;
        countRound = _countRound;
        isPlay = _isPlay;
    }
}
