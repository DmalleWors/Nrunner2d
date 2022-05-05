using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{  public float Speedtoincrease;
    private float increasespeed;
    // Start is called before the first frame update
  
    void Update()
    {
        increasespeed += Speedtoincrease * Time.deltaTime;
        increasespeed = Mathf.Clamp(increasespeed, 0, 12);
        transform.position += new Vector3(increasespeed * Time.deltaTime,0,0);
    }

}
