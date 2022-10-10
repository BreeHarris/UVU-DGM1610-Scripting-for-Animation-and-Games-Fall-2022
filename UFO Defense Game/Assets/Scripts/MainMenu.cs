using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]

    private int sceneToLoad;



    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Indexed Scene to Load 
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit game
        Debug.Log("You have quit the game, goodbye!");
    }
    
}
