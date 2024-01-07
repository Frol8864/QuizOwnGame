using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class ButtonScore : MonoBehaviour
{
    [SerializeField] BlockAnswer blockAnswer;
    [SerializeField] GameObject frameFon;
    [SerializeField] Text text;

    public bool isAct;
    private int valueChangeScore;

    public void StartAnswer(int _valueChangeScore, bool _isAct){
        valueChangeScore = _valueChangeScore;
        text.GetComponent<Text>().text = valueChangeScore.ToString();
        isAct = _isAct;
        OnMouseExit();
    }

    private void OnMouseEnter() {
        frameFon.GetComponent<Image>().color = new Color(1, 0.92f, 0.016f, 1);
    }

    public void OnMouseExit() {
        frameFon.GetComponent<Image>().color = isAct ? new Color(0, 1, 0, 1) : new Color(1, 1, 1, 1);
    }

    private void OnMouseDown() {
        if(isAct) return;
        blockAnswer.DeactiveButton();
        blockAnswer.ChangeValueScore(valueChangeScore);
        isAct = true;
        OnMouseEnter();
    }
}
