using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("dababt");
        Destroy(other.gameObject);
    }
}