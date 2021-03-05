using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    int level; //game state
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password; 
     
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();    
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        password = null;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station\n");
        Terminal.WriteLine("Enter your selection: ");
        Debug.Log("Hello");
        
    }

    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "candy";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "candyman";
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please enter a valid input");
        }
    }
    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen " + level);
        Terminal.WriteLine("Please enter your password "); 
      
    }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Access granted");
        }
        else
        {
            Terminal.WriteLine("Wrong password, please try again");
        }
    }
}
 