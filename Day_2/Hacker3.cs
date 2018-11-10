using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();
	}
	
    void ShowMainMenu () {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello, I'm crazy Jeff! Welcome to my little game... What is your name?");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "noah")
        {
            Terminal.WriteLine("Hello another Jeff!");
        }
        else if (input == "yujin")
        {
            Terminal.WriteLine("Hello sing me the 'The Coconut Song'!");
        }
        else
        {
            Terminal.WriteLine("Hello " + input +"!");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
