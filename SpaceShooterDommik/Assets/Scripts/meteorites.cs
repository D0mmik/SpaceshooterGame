using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorites : MonoBehaviour
{
    private float rotationSpeed = 0;
    public GameObject Explosion;
    private GameObject ExplosionClone;

    void Update()
    {  
        rotationSpeed = Random.Range(50,150);

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); 
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime ); 
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime ); 
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
          ExplosionClone = Instantiate(Explosion, transform.position, Quaternion.identity) as GameObject;
          Destroy(ExplosionClone,3);
          ScoreCounter.Score ++;
          Destroy(other.gameObject);
          Destroy(this.gameObject);
          
        }
    }
    
}
