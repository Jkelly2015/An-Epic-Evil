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
        if(Mathf.Sign(oldMD) != Mathf.Sign(movementDirection))
        {
            sprite.flipX = !sprite.flipX;
        }
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(movementDirection * Time.fixedDeltaTime, 0); 
    }
}
