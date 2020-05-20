using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }

    void StartGame()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        min = min + 1;
    }
    public void OnPressLower()
    {
        max = guess;
        NextGuess();
        max = max - 1;
    }
  
}
