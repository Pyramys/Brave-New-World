using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;

    [SerializeField] private float flt_moveSpeed =6;
    public float flt_jumpSpeed = 8;
    public float flt_gravity = 20;
    [SerializeField] private Vector3 moveDirection= Vector3.zero;


    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (characterController.isGrounded)
        {
            Debug.Log("true");
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            Debug.Log(moveDirection + "move dir1");
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * flt_moveSpeed;
            Debug.Log(moveDirection + "move dir2");
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = flt_jumpSpeed;
            }
        }

        moveDirection.y = moveDirection.y - (flt_gravity * Time.deltaTime);        
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
