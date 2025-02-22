using System;
using System.Collections.Generic;
using Combat.Characters;
using UnityEngine;

namespace Player
{
    public class PlayerPartyManager : MonoSingleton<PlayerPartyManager>
    {
        [SerializeField] private List<Character> _allCharacters;
        [SerializeField] private List<Character> _partyCharacters;
        
        private void PopulateParty()
        {
            
        }
    }
}
