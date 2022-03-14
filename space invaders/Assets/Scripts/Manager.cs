using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject uiRoot;
    private static  GameObject playerInstance;

    private float timeVal ;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (playerInstance == null)
        {
            playerInstance =this.gameObject ;
        }
        else
        { 
            Destroy(gameObject);
        }
       
       
       
    }
    // Update is called once per frame
    void Update()
    {
       timeVal =Time.deltaTime * 5f;
       timeVal--;

       if (Input.GetKey(KeyCode.E))
       {
           backToMainMenu();
       }
       
    }

    void backToMainMenu()
    {
        uiRoot.SetActive(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
