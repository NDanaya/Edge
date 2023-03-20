using DG.Tweening;
using UnityEngine;

namespace DefaultNamespace.EventObjects
{
    public class FallingPlatform : MovingPlatform
    {
        [SerializeField] private float _distance = 10f;
        [SerializeField] private float _duration = 1f;
        [SerializeField] private float _delay = 0.5f;

        public override void Move()
        {
            transform.DOMove(transform.position + Vector3.down * _distance, _duration)
                .OnComplete(OnComplete)
                .SetDelay(_delay);
        }

        private void OnComplete()
        {
            Destroy(gameObject);
        }
    }
}