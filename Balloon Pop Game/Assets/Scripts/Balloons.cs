using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{

    public int clickToPop = 3; //How many clicks until the balloon pops

    public float scaleToIncrease = 0.10f; //Inflation amount, 10%
    public int scoreToGive = 100;
    private ScoreManager scoreManager;



    // Start is called before the first frame update
    void Start()
    {
        // Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        clickToPop -= 1; //Reduce clicks by one
        
        //Inflate the balloon 10% every time it is clicked on
        transform.localScale += Vector3.one * scaleToIncrease;
        

        if(clickToPop == 0)
        {
            // Send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            // Destroy this balloon
            Destroy(gameObject);
        }
    }
}
