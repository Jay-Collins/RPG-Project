using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "AbilityData.Asset", menuName = "Scriptable Objects/Ability")]
    public class Ability : ScriptableObject
    {
        public enum AbilityRange {Single, AOE}
        public enum AbilityType {Damage, Heal, Buff}
        
        [Header("Ability Name")]
        public string abilityName;
        
        [Header("Settings")]
        public AbilityRange abilityRange;
        public AbilityType abilityType;

        public int damageValue;
        public int healingValue;
    }
}
