using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rb;
    PlayerInput _playerInput;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerInput = GetComponent<PlayerInput>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            Debug.Log("jumped" + context.phase);
        }
    }
}
