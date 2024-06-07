using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{


    public void Openplay()
    {
        SceneManager.LoadScene(11);
    }
    public void Openmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Opencredit()
    {
        SceneManager.LoadScene(9);
    }
    public void OpenControl()
    {
        SceneManager.LoadScene(10);
    }
    public void Openexit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
