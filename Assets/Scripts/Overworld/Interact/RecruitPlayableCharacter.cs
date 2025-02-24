using Input;
using Player;
using UnityEngine;

namespace Overworld.Interact
{
    public class RecruitPlayableCharacter : MonoBehaviour
    {
        [SerializeField] private int _characterID;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                InputManager.interactStarted += RecruitCharacter;
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                InputManager.interactStarted -= RecruitCharacter;
            }
        }
        
        private void RecruitCharacter()
        {
            if (PlayerPartyManager.instance.PopulateParty(_characterID))
            {
                Destroy(gameObject);
            }
        }
    }
}
