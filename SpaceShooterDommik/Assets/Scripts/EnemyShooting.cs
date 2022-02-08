﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{ 
  
  private GameObject NewEnemyBullet;
  public float bulletSpeed  = 1500f;
  public GameObject EnemyBullet;
  public Transform ShootingPoint;
  public GameObject Explosion;
  private GameObject ExplosionClone;
  private double timer = 0.3;
  

  void Update()
  {
    timer -= Time.deltaTime;
    if (timer <= 0f)
    { 
        NewEnemyBullet = Instantiate(EnemyBullet,ShootingPoint.position,Quaternion.identity);
        NewEnemyBullet.GetComponent<Rigidbody>().AddForce(Vector3.back * bulletSpeed);
        Destroy (NewEnemyBullet, 2);  
        timer = Random.Range(1,2);
    }   
  }
  void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        { 
          ExplosionClone = Instantiate(Explosion, transform.position, Quaternion.identity) as GameObject;
          Destroy(ExplosionClone,3);
          ScoreCounter.Score ++; 
          Destroy(this.gameObject);
        }
    }
    
}
