using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{


    //private Scene x;
     public GameObject uiRoot;
    private static  anotherGameManager playerInstance;

    public GameObject eventManager;
    
    // Start is called before the first frame update
    
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
        Time.timeScale = 1;
    }


 
    public void backtoMainMenu()
    {
        uiRoot.SetActive(false);
        eventManager.SetActive(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
    
}

