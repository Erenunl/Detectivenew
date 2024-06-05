using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuro : MonoBehaviour
{
    public GameObject neuro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey( KeyCode.T))
     {
         Debug.Log("close");
         
         neuro.SetActive(false);
        
     } 
        if ( Input.GetKey( KeyCode.R))
     {
         Debug.Log("open");
         neuro.SetActive(true);
         
     } 
        
    }
}
