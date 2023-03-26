using Core.Movement.Controller;
using Core.Movement.Data;
using StatsSystem;
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
        public void Initialize(IStatValueGiven statValueGiven)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _directionalMover = new DirectionalMover(_rigidbody, _directionalMovementData, statValueGiven);
        }


        public void MoveXY(Vector2 direction) => _directionalMover.MoveXY(direction);

        public void UpdateAnimation(Vector2 direction) => _animation.Walk(direction);
    }
}
