using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{  
    public Rigidbody player;
    public GameObject DeathScreen;
    public GameObject Player;
    public GameObject Explosion;
    private GameObject ExplosionClone;
    public float Speed = 10f;
    private float horizontal;
    private float vertical;
    
    void Start()
    {
      DeathScreen.SetActive(false);
    }
    void Update()
    {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");

      player.velocity = new Vector3(horizontal, 0 ,vertical) * Speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Enemy"))
      {
        ExplosionClone = Instantiate(Explosion, transform.position, Quaternion.identity) as GameObject;
        DeathScreen.SetActive(true);
        Player.SetActive(false);
        UnityEngine.Cursor.visible = true;
      }
    }
}
