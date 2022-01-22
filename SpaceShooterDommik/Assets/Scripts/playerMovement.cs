using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{  
    public Rigidbody player;
    public float Speed = 10f;
    private float horizontal;
    private float vertical;
    
    void Start()
    {
        
    }

    void Update()
    {
      horizontal = Input.GetAxisRaw("Horizontal");
      vertical = Input.GetAxisRaw("Vertical");

      player.velocity = new Vector3(horizontal, 0 ,vertical) * Speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Enemy"))
      {
         SceneManager.LoadScene("Game");
      }
    }
}
