using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

      float timer = 0;
      float timeToMove = 0.5f;
      int numofMovements = 0;
       float speed = 2f;
       public GameObject enemy;
       public GameObject enemyProjectile;
       public GameObject enemyProjectileClone;
       void Start()
    {
    
    }


    void Update()
    {
       //move down until 5 units one direction
       if (GameManager.playGame)
       {
           if (numofMovements == 4)
           {
               transform.Translate(new Vector3(0, -1f, 0));
               numofMovements = -1;
               speed = -speed;
               timer = 0;
           }

//move sideways
           timer += Time.deltaTime;
           if (timer > timeToMove)
           {
               transform.Translate(new Vector3(speed, 0, 0));
               timer = 0;
               numofMovements++;
           }

           fireEnemyProjectile();
       }
       


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameManager.lives--;
        }
            
    }

    void fireEnemyProjectile()
    {
        if (UnityEngine.Random.Range(0f, 3000f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile,new Vector3(enemy.transform.position.x,enemy.transform.position.y-0.4f,0),enemy.transform.rotation)as GameObject;

        }
    }

    
    
}
