using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDeathzone : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}


