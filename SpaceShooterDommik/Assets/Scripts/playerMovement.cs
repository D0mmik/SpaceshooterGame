using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{   public Rigidbody player;
    public float Speed = 10f;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontal = Input.GetAxisRaw("Horizontal");
      vertical = Input.GetAxisRaw("Vertical");

      player.velocity = new Vector3(horizontal, 0,vertical) * Speed * Time.deltaTime;
    }
}
