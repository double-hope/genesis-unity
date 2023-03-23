using Player;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private PlayerAnimations _playerAnimations;
    private Vector2 _direction;
    
    private void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        _playerController.MoveXY(_direction);
        _playerAnimations.Walk(_direction);
    }
}
