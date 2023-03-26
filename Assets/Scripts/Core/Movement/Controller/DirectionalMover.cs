using Core.Movement.Data;
using UnityEngine;

namespace Core.Movement.Controller
{
    public class DirectionalMover
    {
        private readonly Rigidbody2D _rigidbody;
        private readonly DirectionalMovementData _directionalMovementData;

        public DirectionalMover(Rigidbody2D rigidbody, DirectionalMovementData directionalMovementData)
        {
            _rigidbody = rigidbody;
            _directionalMovementData = directionalMovementData;
        }
        
        public void MoveXY(Vector2 direction)
        {
            Vector2 velocity = _rigidbody.velocity;
            velocity = direction * _directionalMovementData.MovementSpeed;
            _rigidbody.velocity = velocity;
        }
    }
}