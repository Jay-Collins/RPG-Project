using UnityEngine;

namespace Scriptable_Objects
{
    [CreateAssetMenu(fileName = "EnemyData.Asset", menuName = "Scriptable Objects/Enemy")]
    public class EnemyData : ScriptableObject
    {
        [Header("Enemy Name")] 
        [SerializeField] public string name;
        
        [Header("Enemy Stats")]
        public int health;
        public int attack;
        public int defense;
        public int speed;
    }
}
