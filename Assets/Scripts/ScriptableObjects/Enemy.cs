using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Enemy.Asset", menuName = "Enemy", order = 1)]
    public class Character : ScriptableObject
    {
        [SerializeField] private string _enemyName;
        [SerializeField] private int _enemyID;
        [SerializeField] private int _healthPoints;
        [SerializeField] private int _defense;
        [SerializeField] private int _attack;
        [SerializeField] private int _speed;
        
        [SerializeField] private GameObject _enemyPrefab;
    }
}