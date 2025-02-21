using System;
using UnityEngine;

namespace Combat
{
    public class BattleManager : MonoBehaviour
    {
        private enum Phase {Start, Order, Enemy, Player, Combat}
        private Phase combatPhase = Phase.Start;
        
        [SerializeField] private GameObject _playerPartyContainer;
        [SerializeField] private GameObject _enemyPartyContainer;
        
        private void Start()
        {
            OrderPhase();
        }
        
        private void OrderPhase()
        {
            combatPhase = Phase.Order;
            // get speed of both parties and sort them into combat order
        }
        
        private void EnemyPhase()
        {
            combatPhase = Phase.Enemy;
            // select enemy actions
        }

        private void PlayerPhase()
        {
            combatPhase = Phase.Player;
            // cycle through player party and select actions
        }

        private void CombatPhase()
        {
            combatPhase = Phase.Combat;
            // play out combat
        }
    }
}
