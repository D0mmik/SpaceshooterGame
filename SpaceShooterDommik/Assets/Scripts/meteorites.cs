using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorites : MonoBehaviour
{
    private float rotationSpeed = 0;

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
            Destroy(this.gameObject);
        }
    }
}
