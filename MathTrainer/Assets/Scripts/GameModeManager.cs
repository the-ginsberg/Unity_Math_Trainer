using UnityEngine;
using System.Collections;

public class GameModeManager : MonoBehaviour {

    public int selectedGameMode = 0;
    public GameModeManager gameModeManager;

    void Awake ()
    {
        gameModeManager = new GameModeManager();
        print("Game Mode Manager Awake.");
        print(selectedGameMode);

    }
 
}
