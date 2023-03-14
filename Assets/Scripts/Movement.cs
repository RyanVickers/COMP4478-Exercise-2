using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;

    public float speed, xBound;

    void Start()
    {
         body = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
       float h = Input.GetAxisRaw("Horizontal");

       if(h > 0){
        body.velocity = Vector2.right * speed;
       } else if(h < 0){
        body.velocity = Vector2.left * speed; 
       } else
       body.velocity = Vector2.zero;

       transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound ), transform.position.y);
    }
}
