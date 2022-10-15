using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : Singleton<InputManager>
{
    public bool IsMovingPlayer { get; private set; }
    public Vector2 MoveDirectionPlayer { get; private set; }

    private bool _isShootingPressed = false;

    public void MovePressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            IsMovingPlayer = true;
            MoveDirectionPlayer = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            IsMovingPlayer = false;
            MoveDirectionPlayer = context.ReadValue<Vector2>();
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _isShootingPressed = true;
        }
        else if (context.canceled)
        {
            _isShootingPressed = false;
        }
    }

    // For ButtonDown only
    public bool GetShootingPressed()
    {
        bool result = _isShootingPressed;
        _isShootingPressed = false;
        return result;
    }
}
