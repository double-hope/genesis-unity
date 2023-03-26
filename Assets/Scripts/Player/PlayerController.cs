using Core.Movement.Controller;
using Core.Movement.Data;
using UnityEngine;
using Animation = Core.Animation.Animation;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Animation _animation;
        [SerializeField] private DirectionalMovementData _directionalMovementData;
        private Rigidbody2D _rigidbody;
        private DirectionalMover _directionalMover;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _directionalMover = new DirectionalMover(_rigidbody, _directionalMovementData);
        }


        public void MoveXY(Vector2 direction) => _directionalMover.MoveXY(direction);

        public void UpdateAnimation(Vector2 direction) => _animation.Walk(direction);
    }
}
