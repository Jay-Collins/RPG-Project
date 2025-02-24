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
        public string characterName { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int speed { get; set; }
        public int swordProf { get; set; }
        public int greatswordProf { get; set; }
        public int staffProf { get; set; }
        public int bowProf { get; set; }
        public int characterID { get; set; }
        
        private void Awake()
        {
            if (_characterData != null)
            {
                PopulateFromData(_characterData);
            }
        }
        
        private void PopulateFromData(CharacterData data)
        {
            characterName = data.name;
            health = data.health;
            attack = data.attack;
            defense = data.defence;
            speed = data.speed;
            swordProf = data.swordProficiency;
            greatswordProf = data.greatSwordProficiency;
            staffProf = data.staffProficiency;
            bowProf = data.bowProficiency;
            characterID = data.characterID;
        }
    }
}
