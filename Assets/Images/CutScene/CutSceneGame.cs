using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutSceneGame : MonoBehaviour
{
    //7

    private void Start()
    {
        Invoke("SceneTrans", 12f);
    }

    void SceneTrans()
    {
        SceneManager.LoadScene(7);
    }
}
