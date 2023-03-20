using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class KillCollider : MonoBehaviour
    {
        [SerializeField] private string _playerTag = "Player";
        
        // private void OnCollisionEnter(Collision collision)
        // {
        //     if (collision.gameObject.CompareTag(_playerTag))
        //     {
        //         GameStateManager.Instance.Die();
        //     
        //         Destroy(collision.gameObject); //дестроим игрока, получаем его через коллижн
        //     }
        // }
        private void OnTriggerEnter(Collider collision) //регистрирует событие столкновения но не влияет на перемещение объекта
        {
            if (collision.gameObject.CompareTag(_playerTag))
            {
                //Destroy(collision.gameObject); дестроим игрока, получаем его через коллижн
                GameStateManager.Instance.Die();
            }
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(_playerTag))
            {
                GameStateManager.Instance.Die();
            }
        }
    }
}