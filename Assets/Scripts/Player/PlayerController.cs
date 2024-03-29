using UnityEngine;
using UnityEngine.InputSystem;

//ce script a été fais a l'aide d'une video youtube (meme avec le tuto j'en est chiez)
public class PlayerController : MonoBehaviour
{
    CharacterController _controller;
    Vector2 _moveInput;
    [SerializeField] float _speed;
    Vector3 _playerVelocity;
    bool _grounded;
    [HideInInspector] public bool canLook = true;
    float _gravity = -9.81f;
    float _jumpForce = 2f;
    float _xRotation = 0f;
    float _xSens = 30f;
    float _ySens = 30f;
    [SerializeField] Camera _camera;
    Vector2 _lookPos;
    


    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _grounded = _controller.isGrounded;
        MovePlayer();
        PlayerLook();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       _moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Jump();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        _lookPos = context.ReadValue<Vector2>();
    }
   
    
    private void MovePlayer()
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = _moveInput.x;
        moveDirection.z = _moveInput.y;
        _controller.Move(transform.TransformDirection(moveDirection) * _speed * Time.deltaTime);
        _playerVelocity.y += _gravity * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);
    }

    private void PlayerLook()
    {
        _xRotation -= (_lookPos.y * Time.deltaTime) * _ySens;
        _xRotation = Mathf.Clamp(_xRotation, -80f, 80f);
        _camera.transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        transform.Rotate(Vector3.up * (_lookPos.x * Time.deltaTime) * _xSens);
    }

    private void Jump()
    {
        if (_grounded)
        {
            _playerVelocity.y = Mathf.Sqrt(_jumpForce * -1.5f * _gravity);
        }
    }
}
