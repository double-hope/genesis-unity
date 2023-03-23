using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed;
        private Rigidbody2D _rigidbody;
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void MoveXY(Vector2 direction)
        {
            Vector2 velocity = _rigidbody.velocity;
            velocity = direction * _movementSpeed;
            _rigidbody.velocity = velocity;
        }
        
    }
}
