using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Base;
    public GameObject Base2;
    public GameObject Base3;
    public GameObject Base4;
    public static int lives = 3;
    public static float baseHP = 5;
    public static float baseHP2 = 5;
    public static float baseHP3 = 5;
    public static float baseHP4 = 5;
    public static bool playGame =true;
    public TextMeshProUGUI endScreen;
    public TextMeshProUGUI livesScore;
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public GameObject restartButton;
    public static float scored;
    private static GameManager Instance;
    public static int highScoreValue;
    private static  GameObject playerInstance; 

    public GameObject uiRoot;
    // Start is called before the first frame update


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

    void Start()
    {
        Time.timeScale = 1;
        livesScore.text = "Lives: " + lives;
        highScore.text = PlayerPrefs.GetInt("HighScore",0000).ToString();
        restartButton.SetActive(false);
       
        
    }


    public void ResetButton()
    {
        uiRoot.SetActive(false);
        SceneManager.LoadScene(1,LoadSceneMode.Additive);
        
    }

 
    /*void Awake()
    {
        if(Instance!=null)
        {
            Destroy(Instance);
            Instance = this;
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }*/

     
  
    // Update is called once per frame
    void Update()
    {

        
        
        livesScore.text = "Lives: " + lives;
        score.text = "Score: " + scored.ToString("0000");
       

        if (lives <= 0)
        {
            endScreen.text = "GAME OVER!";
            
            if (scored > highScoreValue)
            {
                highScoreValue = (int) scored;
               // highScore.text = "HighScore: " + highScoreValue.ToString("0000");
                if (highScoreValue > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore",highScoreValue);
                    highScore.text = highScoreValue.ToString();
                }
                // DontDestroyOnLoad(this);
            }
            uiRoot.SetActive(false);
            SceneManager.LoadScene(sceneBuildIndex: 2,LoadSceneMode.Additive);
            restartButton.SetActive(true);
            
        }
        else
        {
            restartButton.SetActive(false);
        }

        if (baseHP == 0)
        {
            Destroy(Base);
            
        }

        if (baseHP2 == 0)
        {
            Destroy(Base2);
        }
        if (baseHP3 == 0)
        {
            Destroy(Base3);
        }
        if (baseHP4== 0)
        {
            Destroy(Base4);
        }
    }
}
