using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] private LayerMask PlatformlayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxcollider2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxcollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {


      if (isGrounded() && Input.GetKeyDown(KeyCode.Space)){
          float jumpVelocity = 30f;
          rigidbody2d.velocity = Vector2.up * jumpVelocity;
      }
    }
    private bool isGrounded() {
       RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size, 0f, Vector2.down, .1f, PlatformlayerMask);
       Debug.Log(raycastHit2d.collider);
       return raycastHit2d.collider != null;
    }
}
