using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo : MonoBehaviour
{
    int varTwo = 3;
    private int varOne = 1;
    private string bear = "How are you"; 
    // Start is called before: the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(varTwo);
        varTwo++;
        
    }
}
