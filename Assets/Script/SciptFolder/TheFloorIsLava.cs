using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFloorIsLava : MonoBehaviour
{
   
   
public GameObject GameOver;
public static bool IsDead;

public void start()
{
    IsDead = false;
  
}
   public void OnCollisionEnter(Collision collision)
   {
    GameOver.SetActive(true);
    IsDead = true;
    Time.timeScale = 0;
    Debug.Log("Dead");
   }

}
