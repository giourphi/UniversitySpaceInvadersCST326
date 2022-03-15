using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Animations;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;
  public GameObject bullet;

  public float speed = 5;


    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
      if (col.gameObject.tag == "Enemy")
      {
        Destroy(col.gameObject);
        Destroy(bullet);
        GameManager.scored += 10f;
        GameManager.playGame = true;
      }
      if (col.gameObject.tag == "EnemyGreen")
      {
       
        Destroy(col.gameObject);
        Destroy(bullet);
        GameManager.scored += 20f;
        GameManager.playGame = true;
      }
      if (col.gameObject.tag == "EnemyBlue")
      {
        
        Destroy(col.gameObject);
        Destroy(bullet);
        GameManager.scored += 30f;
        GameManager.playGame = true;
      }
      if (col.gameObject.tag == "EnemyTriangle")
      {
       
        Destroy(col.gameObject);
        Destroy(bullet);
        GameManager.scored += 50f;
        GameManager.playGame = true;
      }

      if (col.gameObject.tag == "Finish")
      {
        Destroy(bullet);
      }

      if (col.gameObject.tag == "Base")
      {
       Destroy(bullet);
       GameManager.baseHP--;
      }
      if (col.gameObject.tag == "Base2")
      {
        Destroy(bullet);
        GameManager.baseHP2--;
      }
     
      if (col.gameObject.tag == "Base3")
      {
        Destroy(bullet);
        GameManager.baseHP3--;
      }
      if (col.gameObject.tag == "Base4")
      {
        Destroy(bullet);
        GameManager.baseHP4--;
      }
      

      
   


    }
}
