using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep our score value
    public TextMeshProUGUI scoreText; // Reference visual text UI element to change



    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<TextMeshProUGUI>
    }
    //This function rewards the player

    public void IncreaseScore(int amount)
    {
        score += amount; //add amount to the score
        UpdateScoreText(); //Update the UI text
    }
    //This function penalizes the player
    public void DecreaseScore(int amount)
    {
        score -= amount; //add amount to the score
        UpdateScoreText(); //Update the UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;

    }
}
