using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class CharacterControllere : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotatespeed = 3.0F;

    private CharacterController _controller;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotatespeed, 0);

        Vector3 forward = transform.transform.forward;

        float curSpeed = speed * Input.GetAxis("Vertical");

        _controller.SimpleMove(forward * curSpeed);
    }
}
