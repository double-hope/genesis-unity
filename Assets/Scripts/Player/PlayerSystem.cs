using System;
using System.Collections.Generic;
using System.Linq;
using InputReader;
using StatsSystem;
using UnityEngine;

namespace Player
{
    public class PlayerSystem : IDisposable
    {
        private readonly StatsController _statsController;
        private readonly PlayerController _playerController;
        private readonly PlayerBrain _playerBrain;
        private List<IDisposable> _disposables;

        public PlayerSystem(PlayerController playerController, List<IEntityInputSource> inputSources)
        {
            _disposables = new List<IDisposable>();
            
            var statStorage = Resources.Load<StatsStorage>($"Player/{nameof(StatsStorage)}");
            var stats = statStorage.Stats.Select(stat => stat.GetCopy()).ToList();
            _statsController = new StatsController(stats);
            _disposables.Add(_statsController);
            
            _playerController = playerController;
            _playerController.Initialize(_statsController);
            
            _playerBrain = new PlayerBrain(_playerController, inputSources);
            _disposables.Add(_playerBrain);
        }

        public void Dispose()
        {
            foreach (var disposable in _disposables)
            {
                disposable.Dispose();
            }
        }
    }
}