using System;
using Input;
using UnityEngine;

namespace Overworld.Player
{
    public class OverworldPlayer : MonoBehaviour
    {
        [SerializeField] private int _speed;
        
        private void OnEnable()
        {
            InputManager.movement += Movement;
        }
        
        private void Movement(Vector2 move)
        {
            Vector3 movement = new Vector3(-move.x, 0, -move.y);
            transform.Translate(movement * (_speed * Time.deltaTime));
        }
    }
}
