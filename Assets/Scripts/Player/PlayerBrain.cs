using System;
using System.Collections.Generic;
using Core.Services.Updater;
using UnityEngine;
using InputReader;

namespace Player
{
    public class PlayerBrain : IDisposable
    {
        private readonly PlayerController _playerController;
        private readonly List<IEntityInputSource> _inputSources;
        public PlayerBrain(PlayerController playerController, List<IEntityInputSource> inputSources)
        {
            _playerController = playerController;
            _inputSources = inputSources;
            ProjectUpdater.Instance.FixedUpdateCalled += OnFixedUpdate;
        }

        private void OnFixedUpdate()
        {
            _playerController.MoveXY(new Vector2(GetHorizontalDirection(), GetVerticalDirection()));
            _playerController.UpdateAnimation(new Vector2(GetHorizontalDirection(), GetVerticalDirection()));
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

        public void Dispose() => ProjectUpdater.Instance.FixedUpdateCalled -= OnFixedUpdate;
        
    }
}