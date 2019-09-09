using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game configuration
    string[] level1Passwords = { "Bernard", "Fuze", "Tea" };
    string[] level2Passwords = { "Developer", "Pokemon", "Coffee" };

    // Game state
    int level;
    string password;
    enum Screen {Menu, Password, Win }
    Screen currentScreen = Screen.Menu;

    // Start is called before the first frame update
    void Start()
    {

        ShowMainMenu();
    }

    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.Menu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }
    
    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");
        
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("I don't understand....");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        CreatePassword();

        Terminal.ClearScreen();
        Terminal.WriteLine(">Enter Password:");

    }

    private void CreatePassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[UnityEngine.Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[UnityEngine.Random.Range(0, level2Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.Menu;
        Terminal.ClearScreen();
        Terminal.WriteLine(">Bernard O/S v6.22 Active " + DateTime.Today.ToString());
        Terminal.WriteLine(">");
        Terminal.WriteLine(">Press 1 to hack Beau");
        Terminal.WriteLine(">Press 2 to hack Honey");
        Terminal.WriteLine(">Press 3 to hack Scarlett");
        Terminal.WriteLine(">");
        Terminal.WriteLine(">Enter your selection:");
    }

   void CheckPassword(string input)
    {
        if(input == password)
        {
            currentScreen = Screen.Win;
            Terminal.WriteLine(">LeveL:"+level+" Access Granted");
        }
        else
        {
            Terminal.WriteLine(">Access Denied");
        }
    }

}
