using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnMap : MonoBehaviour
{   private Rigidbody rb;
    void Start()
    {
      rb = this.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Ship") && rb != null)
      {
        rb.velocity = new Vector3(1, 0 ,-1) * 250 * Time.deltaTime;
      }
      if(other.gameObject.CompareTag("Ship1") && rb != null)
      {
        rb.velocity = new Vector3(-1, 0 ,-1) * 250 * Time.deltaTime;
      }

    }
}
