using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{   public GameObject bullet;
    private GameObject newbullet;
    public float BulletSpeed = 1500f;
    public Transform shootingPoint;
    private float LastBullet;
    public float FireRate;
    public AudioSource ShootSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if (Time.time - LastBullet > 1 / FireRate)
            { 
                LastBullet = Time.time;
                newbullet = Instantiate(bullet,shootingPoint.position,Quaternion.identity);
                newbullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * BulletSpeed);
                ShootSound.Play();
                Destroy (newbullet, 2);
            }
        }
    }
}
