using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class PopUpWin : MonoBehaviour
{
    [SerializeField] GameObject popUp;
    [SerializeField] Text text;

    public void EndGame(string namePlayer) {
        popUp.SetActive(true);
        text.GetComponent<Text>().text = "Лучшим в быдлоконкурсах является - " + namePlayer;
    }
}
