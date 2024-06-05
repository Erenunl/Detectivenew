using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public GameObject ok;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) 
        {
            if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hi");
            ok.SetActive(true);
            if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
        }
        }
    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hi3");
            ok.SetActive(false);
        }
        
    }
}
