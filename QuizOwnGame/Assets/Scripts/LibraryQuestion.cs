using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
//using System;
using UnityEngine.Events;
using UnityEngine.Networking;

public class LibraryQuestion : MonoBehaviour
{
    public List<Question> GetQuestions(){
        List<Question> questions = new List<Question>();
        Question question;
        
        question = new Question("Произнесите грузинский тост имениннику", 3,1,-1,2,0,0);
        questions.Add(question);
        question = new Question("Кончик языка должен быть выше, чем у других", 4,2,-2,2,0,0);
        questions.Add(question);
        question = new Question("Жопа должна быть выше, чем у других", 5,3,-2,3,0,0);
        questions.Add(question);
        question = new Question("Сколько зубов удалил именинник в прошлом году?", 2,-1,-1,1,0,0);
        questions.Add(question);
        question = new Question("В скольких городах спал именинник в прошлом году?", 2,-1,-1,1,0,0);
        questions.Add(question);
        question = new Question("Собрали 100 кг грибов, их влажность 99%. Когда их подсушили, их влажность стала 98%. Какова масса грибов после сушки?", 4,-1,-1,3,0,0);
        questions.Add(question);
        question = new Question("Остановилась печень. Ускорения теряя. Паскали печень раздавили. Поздно. Поздно. Поздно ты не поздно. Регулировщик..", 1,-1,-2,1,0,0);
        questions.Add(question);
        question = new Question("Я включаю радио. Я прослушиваю звуковое сообщение про то, что смотрю на еду, про то что полон сил, про то что уже бухнул..", 2,-1,-2,2,0,0);
        questions.Add(question);
        question = new Question("Я засыпаю в тепле. Я засыпаю в радостном сне, как будто шалаш чужой сгорел, и что все живы..", 3,-1,-2,3,0,0);
        questions.Add(question);
        question = new Question("Назовите недостаток именниника. Объясните почему это недостаток и как поможете исправить его. Побеждает смешной недостаток!", 4,2,-2,2,1,0);
        questions.Add(question);
        question = new Question("Дайте оригинальный совет, как заработать именнинику денег", 4,2,-1,2,1,0);
        questions.Add(question);
        question = new Question("Представим такую историю: Именниник - кандидат в президенты. Вы его спичрайтер. Расскажите предвыборную речь", 4,2,-1,2,1,0);
        questions.Add(question);
        question = new Question("Покажите вашу фотку с самого смешного события, в котором вы участвовали", 3,1,-1,2,1,0);
        questions.Add(question);
        question = new Question("Найти фотку с имениником, с самой смешной совместной историей", 4,2,-1,2,1,0);
        questions.Add(question);
        question = new Question("Сделать фотку, которая переплюнет вечеринку Ивлевой!", 5,3,-1,3,1,0);
        questions.Add(question);

        return questions;
    }
}

public class Question{
    public string text;
    public int scoreWinMain;
    public int scoreTryMain;
    public int scoreLoseMain;
    public int scoreWinNoMain;
    public int scoreTryNoMain;
    public int scoreLoseNoMain;

    public Question(string _text, int _scoreWinMain, int _scoreTryMain, int _scoreLoseMain,
            int _scoreWinNoMain, int _scoreTryNoMain, int _scoreLoseNoMain){
        text = _text;
        scoreWinMain = _scoreWinMain;
        scoreTryMain = _scoreTryMain;
        scoreLoseMain = _scoreLoseMain;
        scoreWinNoMain = _scoreWinNoMain;
        scoreTryNoMain = _scoreTryNoMain;
        scoreLoseNoMain = _scoreLoseNoMain;
    }
}
