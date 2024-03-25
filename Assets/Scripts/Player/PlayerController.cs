using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputMaster _controls;
    private float _moveSpeed;
    private Vector3 _velocity;
    private Vector2 _move;
    private CharacterController _controller;
    

    private void Awake()
    {
        _controls = new InputMaster();
        _controller = GetComponent<CharacterController>();

    }
    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        _move = _controls.Player.Movement.ReadValue<Vector2>();
        Vector3 movement = (_move.y * transform.forward) + (_move.x * transform.right);
        _controller.Move(movement * _moveSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls?.Disable();
    }
}
