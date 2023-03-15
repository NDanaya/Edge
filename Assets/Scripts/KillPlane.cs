using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class KillPlane : MonoBehaviour
    {
        [SerializeField] private string _playerTag;
        
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
                GameStateManager.Instance.Die();
            
                Destroy(collision.gameObject); //дестроим игрока, получаем его через коллижн
            }
        }
    }
}