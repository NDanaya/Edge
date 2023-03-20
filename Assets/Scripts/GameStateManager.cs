using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameStateManager : MonoBehaviour
    {
        //Singleton pattern
        public static GameStateManager Instance;
        private bool _isDead = false;
        private GameObject _player;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(Instance.gameObject);
                return;
            }
            
            Instance = this; //обращение к самому себе, экземпляр созданного класс
        }

        private void Start()
        {
            _player = FindObjectOfType<PlayerInput>().gameObject;
        }

        public void Die() //экземплярный метод не статический
        {
            Destroy(_player);
            _isDead = true;
        }
    }
}