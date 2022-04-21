using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] private LayerMask PlatformlayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxcollider2d;
    public float Speed;
    bool Invincible;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxcollider2d = transform.GetComponent<BoxCollider2D>();
        StartCoroutine(PlayerInvincible());
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponentInChildren<SpriteRenderer>().isVisible && Invincible){
            Debug.Log("out");
            Destroy(gameObject);
        }
        Vector2 movement = new Vector2(0, rigidbody2d.velocity.y);
        float horizontal = Input.GetAxis("Horizontal");
        movement.x = horizontal * Speed * Time.deltaTime;

        rigidbody2d.velocity = movement;

        if (isGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            float jumpVelocity = 50f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size, 0f, Vector2.down, .1f, PlatformlayerMask);
        return raycastHit2d.collider != null;
    }
    IEnumerator PlayerInvincible(){
        yield return new WaitForSeconds(1);
        Invincible = true;
    }
}

