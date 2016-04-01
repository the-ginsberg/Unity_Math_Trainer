using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public GameObject otherGameObject;

    private GameModeManager gameModeManager;

    // Use this for initialization
    void Start () {
        Debug.Log("The game mode selected is " + gameModeManager.selectedGameMode);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Used prior to Initialization
    void Awake ()
    {
        gameModeManager = otherGameObject.GetComponent<GameModeManager>();
    }



    public void QuitButton ()
    {
        // User exits Application
        Application.Quit();
    }

    public void AdditionButton ()
    {
        // Begin Application - Addition Problems
        gameModeManager.selectedGameMode = 1;
        Application.LoadLevel("PlayScene");
    }

    public void SubtractionButton ()
    {
        // Begin Application - Subtraction Problems
        Application.LoadLevel("PlayScene");
    }

    public void MultiplicationButton ()
    {
        // Begin Application - Multiplication Problems
        Application.LoadLevel("PlayScene");
    }

    public void DivisionButton ()
    {
        // Begin Application - Division Problems
        Application.LoadLevel("PlayScene");
    }

    public void FinishButton ()
    {
        // User goes to Score Scene Early and is Scored Based off Questions Complete.
        Application.LoadLevel("ScoreScene");
    }

    public void PlayAgainButton ()
    {
        // Takes User Back to Same Quiz
        Application.LoadLevel("PlayScene");
    }

    public void MainMenuButton ()
    {
        // Takes User to Main Menu
        Application.LoadLevel("MainMenuScene");
    }



}
