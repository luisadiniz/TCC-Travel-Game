using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quiz", menuName = "ScriptableObjects/Quiz Questions", order = 1)]
public class QuizQuestionsScriptable : ScriptableObject
{
    public List<Question> questions;
}

[Serializable]
public struct Question
{
  public string Statement;
  public string FirstOption;
  public string SecondOption;
  public string ThirdOption;
  public int RightOption;
}
    
