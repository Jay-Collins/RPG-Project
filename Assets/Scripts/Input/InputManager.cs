using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
{
    public class InputManager : MonoSingleton<InputManager>
    {
        public static Action<Vector2> movement;
        public static Action interactStarted;
        public static Action cancelStarted;

        private PlayerInputActions _playerInput;

        private void OnEnable()
        {
            InitializeInputs();
        }
    
        private void Update()
        {
            if (_playerInput.Overworld.enabled)
            {
                Movement();
            }
        }

        private void InitializeInputs()
        {
            _playerInput = new PlayerInputActions();
            _playerInput.Overworld.Enable();

            // initialize combat inputs
            _playerInput.Overworld.Interact.started += InteractStarted;
            _playerInput.Overworld.Cancel.started += CancelStarted;
        }

        private void Movement()
        {
            var move = _playerInput.Overworld.Movement.ReadValue<Vector2>();
            movement?.Invoke(move);
        }
        
        private void InteractStarted(InputAction.CallbackContext context)
        {
            if (_playerInput.Overworld.enabled)
            {
                interactStarted?.Invoke();
            }
        }

        private void CancelStarted(InputAction.CallbackContext context)
        {
            if (_playerInput.Overworld.enabled)
            {
                cancelStarted?.Invoke();
            }
        }
    }
}
