using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      SayHello();
    }

//methode
    public void SayHello() 
    {
        Debug.Log ("Hallo");
        Debug.Log ("Liebe Welt");

    }

    // Update is called once per frame
    void Update()
    {
      
    } 
}
