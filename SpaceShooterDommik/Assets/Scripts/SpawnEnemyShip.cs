using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyShip : MonoBehaviour
{   
    private float minX = -19f;
    private float maxX =  19f;
    private float minZ =  13f;
    private float maxZ =  14f;
    private Vector3 randomPosition;
    private double timer = 0.3;
    public float speed;
    public float randomDirection;
    public Transform Spawn;

    public GameObject Ship;
    private GameObject ShipClone;
    private Rigidbody rbship;

    void FixedUpdate()
    {
        randomPosition = new Vector3(Random.Range(minX, maxX), 0,Random.Range(minZ, maxZ));
        randomDirection = Random.Range(0,2)*2-1;

        timer -= Time.deltaTime;
        if (timer <= 0)
        { 
          ShipClone = Instantiate(Ship,randomPosition,Quaternion.identity);
          rbship = ShipClone.GetComponent<Rigidbody>();
          rbship.velocity = new Vector3(randomDirection, 0 ,-1) * speed * Time.deltaTime;   
          StartCoroutine(ChangeDiretion());
          Destroy(ShipClone,10);
          timer = 2;  //za jak dlouho se spawne EnemyShip
        } 
        

    }
    IEnumerator ChangeDiretion()
    {
      yield return new WaitForSeconds(Random.Range(1,4));
      if (ShipClone != null)
      {
        rbship.velocity = new Vector3(randomDirection, 0 ,-1) * 5;
      }
    }
}
