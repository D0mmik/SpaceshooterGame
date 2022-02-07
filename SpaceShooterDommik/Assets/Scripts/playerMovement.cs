using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{  
    public Rigidbody PlayerRB;
    public GameObject DeathScreen;
    public GameObject Player;
    public GameObject Explosion;
    private GameObject ExplosionClone;
    public float speed = 6000f;
    private float horizontal;
    private float vertical;
    
    void Start()
    {
      DeathScreen.SetActive(false);
    }
    void FixedUpdate()
    {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");

      PlayerRB.velocity = new Vector3(horizontal, 0 ,vertical) * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Enemy"))
      {
        ExplosionClone = Instantiate(Explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(ExplosionClone,3);
        DeathScreen.SetActive(true);
        Player.SetActive(false);
        UnityEngine.Cursor.visible = true;
      }
    }
}
