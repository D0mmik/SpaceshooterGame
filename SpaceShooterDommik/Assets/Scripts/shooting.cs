using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{   public GameObject bullet;
    private GameObject newbullet;
    public float bulletspeed = 1500f;
    public Transform shootingPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            newbullet = Instantiate(bullet,shootingPoint.position,Quaternion.identity);
            newbullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * bulletspeed);
            Destroy (newbullet, 2);
            
        }
    }
}
