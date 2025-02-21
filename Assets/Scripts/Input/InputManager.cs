using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoSingleton<InputManager>
{
    public static Action<Vector2> cursorMovement;
    public static Action confirmStarted;
    public static Action cancelStarted;

    private PlayerInputActions _playerInput;

    private void OnEnable()
    {
        InitializeInputs();
    }
    
    private void Update()
    {
        if (_playerInput.BattleInput.enabled)
        {
            CursorMovement();
        }
    }

    private void InitializeInputs()
    {
        _playerInput = new PlayerInputActions();
        _playerInput.BattleInput.Enable();

        // initialize combat inputs
        _playerInput.BattleInput.Confirm.started += ConfirmStarted;
        _playerInput.BattleInput.Cancel.started += CancelStarted;
    }

    private void CursorMovement()
    {
        var move = _playerInput.BattleInput.Cursor.ReadValue<Vector2>();
        cursorMovement?.Invoke(move);
    }
    
    private void ConfirmStarted(InputAction.CallbackContext context)
    {
        if (_playerInput.BattleInput.enabled)
        {
            confirmStarted?.Invoke();
        }
    }

    private void CancelStarted(InputAction.CallbackContext context)
    {
        if (_playerInput.BattleInput.enabled)
        {
            cancelStarted?.Invoke();
        }
    }
}
