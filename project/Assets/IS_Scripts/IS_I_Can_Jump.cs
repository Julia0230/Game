using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//based on Character controller script from  https://github.com/valgoun/CharacterController and https://medium.com/ironequal/unity-character-controller-vs-rigidbody-a1e243591483

public class IS_I_Can_Jumpz : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpHeight = 2f;
    public float Gravity = -29.8f;
    public float GroundDistance = 0.2f;
    public float DashDistance = 5f;
    public LayerMask Ground;
    public Vector3 Drag;

    private CharacterController _controller;
    private Vector3 _velocity;
    public bool _isGrounded = true;
    public Transform _groundChecker;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _groundChecker = transform.GetChild(1);
    }

    void Update()
    { 
       if(_controller.isGrounded)
         {_isGrounded = true;  }
         else
         {
             _isGrounded = false;
         }
        if (_isGrounded && _velocity.y < 0)
           { _velocity.y = 0f;
        
           }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        if (move != Vector3.zero)
            transform.forward = move;

        if (Input.GetButtonDown("Jump") && _isGrounded)
            _velocity.y += Mathf.Sqrt(JumpHeight * -2f * Gravity);
        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Dash");
            _velocity += Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Drag.x + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * Drag.z + 1)) / -Time.deltaTime)));
        }


        _velocity.y += Gravity * Time.deltaTime;

        _velocity.x /= 1 + Drag.x * Time.deltaTime;
        _velocity.y /= 1 + Drag.y * Time.deltaTime;
        _velocity.z /= 1 + Drag.z * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);

  
    }

}