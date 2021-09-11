using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class RotateLocmothion : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private Vector3 moveDirecthion = Vector3.zero;
    [SerializeField]
    private float horizon, vertical;

    [SerializeField]
    private float speed = 6.0f;
    [SerializeField]
    private float jumpSpeed = 8.0f;
    [SerializeField]
    private float gravity = 20.0f;
    [SerializeField]
    private float rotateSpeed = 3.0f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            transform.Rotate ( new Vector3(0, rotateSpeed*horizon, 0));
          
            moveDirecthion = speed * vertical * transform.forward;

            if (Input.GetButton("Jump"))
            {
                moveDirecthion.y = jumpSpeed;
            }
        }

        moveDirecthion.y -= gravity * Time.deltaTime;
        controller.Move(moveDirecthion * Time.deltaTime);
    }
}
