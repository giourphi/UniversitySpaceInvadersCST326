using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
 public GameObject bullet;
 public GameObject bulletClone;
 public GameObject player;
 //public GameObject player;

 
     void Update()
    {
        if (GameManager.lives > 0)
        {
            Movement();
            fireProjectile();
        }
    }

     void Movement()
     {
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate(new Vector3(-5*Time.deltaTime,0,0));
         }
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(new Vector3(5*Time.deltaTime,0,0));
         }   
         if (Input.GetKey(KeyCode.D))
         {
             transform.Translate(new Vector3(5*Time.deltaTime,0,0));
         }   
         if (Input.GetKey(KeyCode.A))
         {
             transform.Translate(new Vector3(-5*Time.deltaTime,0,0));
         }   
     }

     void fireProjectile()
     {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             bulletClone = Instantiate(bullet,new Vector3(player.transform.position.x,player.transform.position.y+0.8f,0),transform.rotation) as GameObject;
             
         }
     }
     
     
     
}
