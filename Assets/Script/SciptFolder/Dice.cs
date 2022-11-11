using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour

{
    //Variables
    public int diceNumber;
    public int diceSites = 6;


    // Start is called before the first frame update
    void Start()
    {
    diceNumber = Random.Range(1,diceSites);
     
     Debug.Log("You rolled a " + diceNumber);

     //if the number is greater than 3 you win
    if (diceNumber > 3)
            {
                Debug.Log("You won!");
            }
   
   
   // if not, you loose
    else 
            {
                Debug.Log("You loose");
            }      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
