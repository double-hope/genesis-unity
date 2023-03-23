using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerBrain
    {
        private readonly PlayerController _playerController;
        private readonly PlayerAnimations _playerAnimations;
        private readonly List<IEntityInputSource> _inputSources;
        public PlayerBrain(PlayerController playerController, PlayerAnimations playerAnimations, List<IEntityInputSource> inputSources)
        {
            _playerController = playerController;
            _playerAnimations = playerAnimations;
            _inputSources = inputSources;
        }

        public void OnFixedUpdate()
        {
            _playerController.MoveXY(new Vector2(GetHorizontalDirection(), GetVerticalDirection()));
            _playerAnimations.Walk(new Vector2(GetHorizontalDirection(), GetVerticalDirection()));
        }

        private float GetHorizontalDirection()
        {
            foreach (var inputSource in _inputSources)
            {
                if(inputSource.HorizontalDirection == 0)
                    continue;
                return inputSource.HorizontalDirection;
            }

            return 0;
        }
        
        private float GetVerticalDirection()
        {
            foreach (var inputSource in _inputSources)
            {
                if(inputSource.VerticalDirection == 0)
                    continue;
                return inputSource.VerticalDirection;
            }

            return 0;
        }
    }
}