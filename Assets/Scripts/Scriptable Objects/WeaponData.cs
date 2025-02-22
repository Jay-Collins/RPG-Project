using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "WeaponData.Asset", menuName = "Scriptable Objects/WeaponData")]
    public class WeaponData : ScriptableObject
    {
        public enum WeaponType {Sword, Greatsword, Bow, Staff}
        
        [Header("Weapon Name")] 
        public string name;
        
        [Header("Stats")]
        public int damage;
        public int defense;
        public int speed;

        [Header("Weapon ID")] 
        public int weaponID;
    }
}
