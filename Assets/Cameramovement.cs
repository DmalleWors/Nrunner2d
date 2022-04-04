using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayers;
    [SerializeField] private float runSpeed = 5f;


    private CharacterController characterController;
    private Vector3 velocity;
    private bool isGrounded;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
       characterController = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = 1; 
         characterController.Move(new Vector3(horizontalInput * runSpeed, 0, 0) * Time.deltaTime);
    }


}
