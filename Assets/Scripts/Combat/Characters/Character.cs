using System;
using Scriptable_Objects;
using UnityEngine;

namespace Combat.Characters
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterData _characterData;
        [SerializeField] private WeaponData _weapon;
        [SerializeField] private ArmorData _armor;
        private string _characterName { get; set; }
        private int _health { get; set; }
        private int _attack { get; set; }
        private int _defense { get; set; }
        private int _speed { get; set; }
        private int _swordProf { get; set; }
        private int _greatswordProf { get; set; }
        private int _staffProf { get; set; }
        private int _bowProf { get; set; }
        
        private void Awake()
        {
            if (_characterData != null)
            {
                PopulateFromData(_characterData);
            }
        }
        
        private void PopulateFromData(CharacterData data)
        {
            _characterName = data.name;
            _health = data.health;
            _attack = data.attack;
            _defense = data.defence;
            _speed = data.speed;
            _swordProf = data.swordProficiency;
            _greatswordProf = data.greatSwordProficiency;
            _staffProf = data.staffProficiency;
            _bowProf = data.bowProficiency;
        }
    }
}
