using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour

{
    //Variables
    public int diceNumber;
    public int diceSites = 50;
    public AudioSource source;
    public AudioClip clip;



    // Start is called before the first frame update
    void Start()
    {
    diceNumber = Random.Range(1,diceSites);
     
     Debug.Log("You rolled a " + diceNumber);

     //if the number is less than 9 you win
    if (diceNumber < 9)
            {
                Debug.Log("You won!");
                source.PlayOneShot(clip);
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
