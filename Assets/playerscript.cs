using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] private LayerMask PlatformlayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxcollider2d;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxcollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(0, rigidbody2d.velocity.y);
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -Speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            movement.x = Speed * Time.deltaTime;
        }

        rigidbody2d.velocity = movement;

        if (isGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            float jumpVelocity = 30f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size, 0f, Vector2.down, .1f, PlatformlayerMask);
        return raycastHit2d.collider != null;
    }

}

