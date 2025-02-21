using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Character.Asset", menuName = "Character", order = 0)]
    public class Enemy : ScriptableObject
    {
        [SerializeField] private string _characterName;
        [SerializeField] private int _characterID;
        [SerializeField] private int _healthPoints;
        [SerializeField] private int _defense;
        [SerializeField] private int _attack;
        [SerializeField] private int _speed;
        
        [SerializeField] private GameObject _characterPrefab;
    }
}