using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{   public float Speed;
    // Start is called before the first frame update
  
    void Update()
    {
        transform.position += new Vector3(Speed * Time.deltaTime,0,0);
    }

}
