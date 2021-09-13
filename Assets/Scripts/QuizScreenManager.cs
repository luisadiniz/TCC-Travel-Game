using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScreenManager : MonoBehaviour
{

    [SerializeField] QuestionsScriptableObject _questionsScriptable;

    [Header("UI")]
    [SerializeField] Text _statement;
    [SerializeField] Text _anwserOne;
    [SerializeField] Text _anwserTwo;
    [SerializeField] Text _anwserThree;

    private int _rightAnwser;

    public void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        int index = GetRandomQuestion();

        _statement.text = _questionsScriptable.questions[index].Statement;
        _anwserOne.text = _questionsScriptable.questions[index].AnswerOne;
        _anwserTwo.text = _questionsScriptable.questions[index].AnswerTwo;
        _anwserThree.text = _questionsScriptable.questions[index].AnswerThree;

        _rightAnwser = _questionsScriptable.questions[index].RightAnswer;
    }

    private int GetRandomQuestion()
    {
        int randomIndex = Random.Range(0, _questionsScriptable.questions.Count);
        Debug.Log("Index" + randomIndex);
        return randomIndex;
    }

    public void OnAnwserClick(int choice)
    {
        if(_rightAnwser == choice)
        {
            Debug.Log("Right!");
        }
        else
        {
            Debug.Log("Wrong!");
        }
    }
}
