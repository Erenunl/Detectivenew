using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject exit,harry,jessica,pedofili,csecim,panel1,panel2,Closepanel1,Closepanel2;
    public void OpenClosepanel1()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        }   
    public void OpenClosepanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
    }

    public void Opencsecim()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        csecim.SetActive(true);
        harry.SetActive(false);
        jessica.SetActive(false);
        pedofili.SetActive(false);
    }
      public void Openjessica()
    {
       jessica.SetActive(true);
        csecim.SetActive(false);
        Debug.Log("hi");
    }
      public void Openharry()
    {
        harry.SetActive(true);
        csecim.SetActive(false);
    }
      public void Openpedofili()
    {
        pedofili.SetActive(true);
        csecim.SetActive(false);
    }
    public void Openexit()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
       
        SceneManager.LoadScene(7);
    }
    public void Openpanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
       
        Debug.Log("hi");
        
    }
    public void Openpanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        
        
    }
    
}
