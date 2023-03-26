using Core.Movement.Data;
using StatsSystem;
using StatsSystem.Enum;
using UnityEngine;

namespace Core.Movement.Controller
{
    public class DirectionalMover
    {
        private readonly Rigidbody2D _rigidbody;
        private readonly DirectionalMovementData _directionalMovementData;
        private readonly IStatValueGiven _statValueGiven;

        public DirectionalMover(Rigidbody2D rigidbody, DirectionalMovementData directionalMovementData, IStatValueGiven statValueGiven)
        {
            _rigidbody = rigidbody;
            _directionalMovementData = directionalMovementData;
            _statValueGiven = statValueGiven;
        }
        
        public void MoveXY(Vector2 direction)
        {
            Vector2 velocity = _rigidbody.velocity;
            velocity = direction * _statValueGiven.GetStatValue(StatType.Speed);
            _rigidbody.velocity = velocity;
        }
    }
}