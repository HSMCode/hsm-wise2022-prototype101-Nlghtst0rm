using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoal : MonoBehaviour



{
    public GameObject[] myObjects;

    // Start is called before the first frame update
    void Start()
    {
     int randomIndex = Random.Range(0, myObjects.Length);  
     Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11), 3, Random.Range(6, 11));
     Instantiate(myObjects[randomIndex], randomSpawnPosition,Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
