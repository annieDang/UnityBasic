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
        Terminal.WriteLine("Hello, I'm crazy Jeff! Welcome to my little game...");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
