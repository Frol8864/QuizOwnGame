using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class OK : MonoBehaviour
{
    [SerializeField] PanelQuestion panelQuestion;
    [SerializeField] GameObject frameFon;

    private void OnMouseEnter() {
        frameFon.GetComponent<Image>().color = new Color(1, 0.92f, 0.016f, 1);
    }

    private void OnMouseExit() {
        frameFon.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }

    private void OnMouseDown() {
        panelQuestion.CalculateScore();
    }
}
