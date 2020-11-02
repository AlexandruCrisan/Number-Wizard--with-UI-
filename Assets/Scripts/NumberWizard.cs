using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    
    void Start()
    {
        guess = Random.Range(min, max);
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        //guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }
    
}
