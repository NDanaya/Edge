using UnityEngine;

namespace DefaultNamespace
{
    public interface IAiState
    {
        public Vector3 GetDirection(Vector3 transformPosition);

        public IAiState GetNextState();

        public void OnUpdate(float deltaTime);
    }
}