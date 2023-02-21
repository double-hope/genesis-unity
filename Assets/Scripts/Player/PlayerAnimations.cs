using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private static readonly int MovementX = Animator.StringToHash("MovementX");
    private static readonly int MovementY = Animator.StringToHash("MovementY");
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Walk(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            _animator.SetFloat(MovementX, direction.x);
            _animator.SetFloat(MovementY, direction.y);
            _animator.SetBool(isWalking, true);
        }
        else
        {
            _animator.SetBool(isWalking, false);
        }
    }
}
