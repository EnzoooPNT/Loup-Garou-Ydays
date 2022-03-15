using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class detect : MonoBehaviour
{
    void Update()
    
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Game on !");
        }
        
    }
}
