using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Hello Chemlock....";

        ShowMainMenu(greeting);
    }

    void OnUserInput(string input)
    {
        print(input);
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine(">Bernard O/S v6.22 Active " + DateTime.Today.ToString());
        Terminal.WriteLine(">");
        Terminal.WriteLine(">Press 1 to hack Beau");
        Terminal.WriteLine(">Press 2 to hack Honey");
        Terminal.WriteLine(">Press 3 to hack Scarlett");
        Terminal.WriteLine(">");
        Terminal.WriteLine(">Enter your selection:");
    }
}
