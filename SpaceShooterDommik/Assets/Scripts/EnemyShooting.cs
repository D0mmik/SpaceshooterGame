using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{ 
  
  private GameObject NewEnemyBullet;
  [SerializeField] private float BulletSpeed  = 1500f;
  public GameObject EnemyBullet;
  public Transform ShootingPoint;
  public GameObject Explosion;
  private GameObject ExplosionClone;
  private double Timer = 0.3;

  void Update()
  {
    Timer -= Time.deltaTime;
    if (Timer <= 0f)
    { 
        NewEnemyBullet = Instantiate(EnemyBullet,ShootingPoint.position,Quaternion.identity);
        NewEnemyBullet.GetComponent<Rigidbody>().AddForce(Vector3.back * BulletSpeed);
        Destroy (NewEnemyBullet, 2);  
        Timer = Random.Range(1,3);
    }   
  }
  void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        { 
          ExplosionClone = Instantiate(Explosion, transform.position, Quaternion.identity) as GameObject;
          ScoreCounter.Score ++; 
          Destroy(this.gameObject);
        }
    }
    
}
