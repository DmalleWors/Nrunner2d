using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    void OnTriggerEnter(Collider2D collision) {

        Destroy(collision.gameObject);
    }
}
