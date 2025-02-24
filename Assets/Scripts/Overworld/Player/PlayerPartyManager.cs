using System;
using System.Collections.Generic;
using System.Linq;
using Combat.Characters;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerPartyManager : MonoSingleton<PlayerPartyManager>
    {
        [SerializeField] private List<Character> _allCharacters;
        [SerializeField] private List<Character> _partyCharacters;
        
        public bool PopulateParty(int characterID)
        {
            var alreadyInParty = _partyCharacters.Contains(_allCharacters[characterID]);
            
            if (alreadyInParty)
                return false;
            
            foreach (var character in _allCharacters.Where(character => characterID == character.characterID))
            {
                _partyCharacters.Add(character);
            }

            return true;
        }
    }
}
