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
    private double Timer = 0.3;
    public float Speed;
    public float randomDirection;
    public Transform spawn;

    public GameObject Ship;
    private GameObject ShipClone;

    void Update()
    {
        randomPosition = new Vector3(Random.Range(minX, maxX), 0,Random.Range(minZ, maxZ));
        randomDirection = Random.Range(0,2)*2-1;

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        { 
          ShipClone = Instantiate(Ship,randomPosition,Quaternion.identity);
          ShipClone.GetComponent<Rigidbody>().velocity = new Vector3(randomDirection, 0 ,-1) * Speed * Time.deltaTime;   
          StartCoroutine(ChangeDiretion());
          Destroy(ShipClone,7);
          Timer = 3;  //za jak dlouho se spawne EnemyShip
        } 
        

    }
    IEnumerator ChangeDiretion()
    {
      yield return new WaitForSeconds(Random.Range(1,4));
      if (ShipClone != null)
      {
        ShipClone.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        ShipClone.GetComponent<Rigidbody>().velocity = new Vector3(randomDirection, 0 ,-1) * Speed * Time.deltaTime;
      }
    }
}
