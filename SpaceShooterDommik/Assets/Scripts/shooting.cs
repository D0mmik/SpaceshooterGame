using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{   public GameObject Bullet;
    private GameObject NewBullet;
    public float bulletSpeed = 1500f;
    public Transform shootingPoint;
    private float lastBullet;
    public float fireRate;
    public AudioSource ShootSound;
    public GameObject settings;
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && pausemenu.activeSelf == false && settings.activeSelf == false)
        {
            if (Time.time - lastBullet > 1 / fireRate)
            { 
                lastBullet = Time.time;
                NewBullet = Instantiate(Bullet,shootingPoint.position,Quaternion.identity);
                NewBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * bulletSpeed);
                ShootSound.Play();
                Destroy (NewBullet, 2);
            }
        }
    }
}
