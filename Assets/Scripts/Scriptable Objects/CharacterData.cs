using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "CharacterData.Asset", menuName = "Scriptable Objects/CharacterData")]
    [System.Serializable]
    public class CharacterData : ScriptableObject
    {
        [Header("Character Name")]
        public string name;
        
        [Header("Character Stats")]
        public int health;
        public int attack;
        public int defence;
        public int speed;

        [Header("Character Proficiencies")]
        public int swordProficiency;
        public int greatSwordProficiency;
        public int staffProficiency;
        public int bowProficiency;
        
        [Header("Character ID")]
        public int characterID;

        [Header("Prefab")] 
        public GameObject prefab;
    }
}
