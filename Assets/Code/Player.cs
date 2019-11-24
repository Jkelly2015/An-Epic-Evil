using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    private float movementDirection = 0.0f;
    private SpriteRenderer sprite;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float oldMD = movementDirection;
        movementDirection = Input.GetAxisRaw("Horizontal") * movementSpeed;
        if (movementDirection>0)
        {
            sprite.flipX = false;
        } else if(movementDirection < 0)
        {
            sprite.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(movementDirection * Time.fixedDeltaTime, 0); 
    }
}
