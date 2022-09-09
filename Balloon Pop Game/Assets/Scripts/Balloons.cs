using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{

    public int clickToPop = 3; //How many clicks until the balloon pops

    public float scaleToIncrease = 0.10f; //Inflation amount, 10%



    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(gameObject);
        }
    }
}
