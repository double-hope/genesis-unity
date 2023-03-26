using System.Collections.Generic;
using InputReader;

namespace Player
{
    public class PlayerSystem
    {
        private readonly PlayerController _playerController;
        private readonly PlayerBrain _playerBrain;

        public PlayerSystem(PlayerController playerController, List<IEntityInputSource> inputSources)
        {
            _playerController = playerController;
            _playerBrain = new PlayerBrain(_playerController, inputSources);
        }
    }
}