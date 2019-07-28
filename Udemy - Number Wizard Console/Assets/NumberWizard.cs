using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Higher: Press Up - Lower: Press Down - Equal: Press Enter");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Debug.Log("Higher You Say? Ok.");
            MakeGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log("Really? Lower? Ok.");
            MakeGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew I'd guess it!");
            StartGame();

        }
    }

    void MakeGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(guess);
    }
}
