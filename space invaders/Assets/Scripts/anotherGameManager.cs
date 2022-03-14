using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anotherGameManager : MonoBehaviour
{

    public GameObject uiRoot;
    private static  anotherGameManager playerInstance; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    void Awake()
    {
        
        if (playerInstance != null)
        {
            Destroy(playerInstance);
            playerInstance = this;

        }
        else
        { 
            playerInstance =this ;
        }

       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {
        uiRoot.SetActive(false);
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

}
