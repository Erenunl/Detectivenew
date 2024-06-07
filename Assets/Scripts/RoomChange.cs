using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RoomChange : MonoBehaviour
{
    [SerializeField] float LoadDelay = 0.5f;
    public int sceneIndex;
    void OnTriggerStay2D(Collider2D other) 
    {
     if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Player")
      {
          Invoke("ReloadScene", LoadDelay );
      }
    } 
    void ReloadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
