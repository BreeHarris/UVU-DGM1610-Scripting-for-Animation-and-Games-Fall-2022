using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Flag Stats")]
    public bool hasFlag;
    public bool flagPlaced;

    //public int scoreToWin;
    //public int curScore;

    //public bool gamePaused;

    // Instance
    public static GameManager instance;

    void Awake()
    {
        // Set the instance to this script
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Flag bools
        hasFlag = false;
        flagPlaced = false;
        Time.timeScale = 1.0f;
    }

    public void PlaceFlag()
    {
        flagPlaced = true;
    }
    
    void WinGame()
    {
        Debug.Log("You've won the game!");
        Time.timeScale = 0; // Freeze the game
    }

    // Update is called once per frame
    void Update()
    {
        if(flagPlaced == true)
        {
            WinGame();
        }

        /*if(Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
*/
    }
    
    /*public void TogglePauseGame()
    {
        gamePaused = !gamePaused;
        Time.timeScale = gamePaused == true ? 0.0f : 1.0f;

    }
*/
}
