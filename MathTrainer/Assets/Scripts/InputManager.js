#pragma strict



function Start () {
    
}


function Update () {
    //Input Test
    if (Input.GetKeyDown(KeyCode.Mouse0))
        print ("Mouse key was pressed");
}

function QuitButton () {
    // User exits Application
    Application.Quit ();
}

function AdditionButton () {
    // Begin Application - Addition Problems
    Application.LoadLevel ("PlayScene");
}

function SubtractionButton () {
    // Begin Application - Subtraction Problems
    Application.LoadLevel ("PlayScene");
}

function MultiplicationButton () {
    // Begin Application - Multiplication Problems
    Application.LoadLevel ("PlayScene");
}

function DivisionButton () {
    // Begin Application - Division Problems
    Application.LoadLevel ("PlayScene");
}

function FinishButton () {
    // User goes to Score Scene Early and is Scored Based off Questions Complete.
    Application.LoadLevel ("ScoreScene");
}

function PlayAgainButton () {
    // Takes User Back to Same Quiz
    Application.LoadLevel ("PlayScene");
}

function MainMenuButton () {
    // Takes User to Main Menu
    Application.LoadLevel ("MainMenuScene");
}

