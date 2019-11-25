using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    int min = 0;
    int max = 100;
    int guess;
    [SerializeField] TextMeshProUGUI numberContainer;


    private void Start()
    {
        guess = Random.Range(min, max);
        printNumber();
    }

    public void GuessHigher() {
        min = guess;
        guess = Random.Range(min, max);
        printNumber();
    }

    public void GuessLower()
    {
        max = guess;
        guess = Random.Range(min, max);
        printNumber();
    }

    private void printNumber()
    {
        numberContainer.text = guess.ToString();
    }
}
