using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl10Player : MonoBehaviour
{
     private Rigidbody2D rb;
     public float moveSpeedModifier = 0.5f;
     public float moveSpeedModifiery = 0.5f;
     float dirX, dirY;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeedModifier;
		dirY = Input.acceleration.y * moveSpeedModifiery;
        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2 (rb.velocity.x + dirX, rb.velocity.y + dirY);
    }
}
