using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{
    //verschiedene Variablen
   public int playerHealth;
   public int a;
   public int b;
   public int c;
   public int d;
   public int e;
   public int f;

   public string Playername;
   public bool IsAlive=false;
   public float Playerspeed;
   public double Motivation;

   
    // Start is called before the first frame update
    void Start()
    {
        //Festlegung der verschiedenen Variablen
       playerHealth = 15;
       a = 3;
       b = 8;
       c = 2;
       d = 6;
       e = 4;
       f = (a+b+c+d+e)/3;
       Playerspeed = 1.4f;
      Motivation = 0.0002;
      Debug.Log(f);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
