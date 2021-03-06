using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningMeteorites : MonoBehaviour
{
    private GameObject spawnthis;
    private GameObject clone;

    public GameObject meteorite1;
    public GameObject meteorite2;
    public GameObject meteorite3;
    private float min = 0;
    private float max = 3;
    private float number;
    public double timer = 0.3;
    public float speed = 1500;
    
    private float minX = -19;
    private float maxX =  19;
    private float minZ =  13;
    private float maxZ =  14;
    public Vector3 randomPosition;

    void Update()
    {   
        randomPosition = new Vector3(Random.Range(minX, maxX), 0,Random.Range(minZ, maxZ));
        number = Random.Range(min,max);

        if(number <= 1)
        {
          spawnthis = meteorite1;
        }
        else if(number <= 2)
        {
          spawnthis = meteorite2;
        }
         else if(number <= 3)
        {
            spawnthis = meteorite3;
        }



        timer -= Time.deltaTime;
        if (timer <= 0f)
        { 
          clone = Instantiate(spawnthis,randomPosition,Quaternion.Euler(Random.Range(0, 360),Random.Range(0, 360),Random.Range(0, 360)));
          clone.GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
          Destroy(clone,7);
         
          timer = 0.5;
        } 
        
    }
    


}
