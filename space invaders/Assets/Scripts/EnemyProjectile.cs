using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

  //  public GameObject projectile;

    public GameObject enemyProjectile;

     Vector3 respawn = new Vector3(-.11f, -4.66f,-2.97f );
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,-5*Time.deltaTime,0));
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.transform.position = respawn;
            Destroy(enemyProjectile);
            GameManager.lives--;
            GameManager.playGame = false;
      
         
        }
        if (col.gameObject.tag == "Finish")
        {
            Destroy(enemyProjectile);
        }
        if (col.gameObject.tag == "Base")
        {
            Destroy(enemyProjectile);
            GameManager.baseHP--;
        }
        if (col.gameObject.tag == "Base2")
        {
            Destroy(enemyProjectile);
            GameManager.baseHP2--;
        }
        if (col.gameObject.tag == "Base3")
        {
            Destroy(enemyProjectile);
            GameManager.baseHP3--;
        }
        if (col.gameObject.tag == "Base4")
        {
            Destroy(enemyProjectile);
            GameManager.baseHP4--;
        }
    }
}
