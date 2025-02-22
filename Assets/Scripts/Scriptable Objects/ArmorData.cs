using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "ArmorData.asset", menuName = "Scriptable Objects/ArmorData")]
    public class ArmorData : ScriptableObject
    {
        public enum ArmorType {Plate, Leather, Cloth}
        
        [Header("Armor Name")] 
        public string name;
        
        [Header("Stats")]
        public int damage;
        public int defense;
        public int speed;

        [Header("Armor ID")] 
        public int armorID;
    }
}
