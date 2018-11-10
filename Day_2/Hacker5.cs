using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game state
    int number;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to awesome suicide squad! Which weapon do you like");
        Terminal.WriteLine("Press 1 to pick a banana.");
        Terminal.WriteLine("Press 2 to pick a kokonut.");
        Terminal.WriteLine("Press 3 to pick a coke.");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go direct to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            number = 1;
            StartGame();
        }
        else if (input == "2")
        {
            number = 2;
            StartGame();
        }
        else if (input == "3")
        {
            number = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }

    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen number " + number);
        Terminal.WriteLine("Throw it!!!");
    }
}