using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameStateManager : MonoBehaviour
    {
        public static GameStateManager Instance;
        private bool _isDead = false;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(Instance.gameObject);
                return;
            }
            
            Instance = this; //обращение к самому себе, экземпляр созданного класс
        }

        public void Die() //экземплярный метод не статический
        {
            Debug.Log("Player died");
            _isDead = true;
        }
    }
}