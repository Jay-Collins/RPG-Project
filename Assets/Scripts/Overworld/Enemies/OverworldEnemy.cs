using System;
using UnityEngine;

namespace Overworld.Enemies
{
    public class OverworldEnemy : MonoBehaviour
    {
        [SerializeField] private EnemyPartyManager _enemyPartyManager;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                InitiateBattle();
            }
        }
        
        private void InitiateBattle()
        {
            
        }
    }
}
