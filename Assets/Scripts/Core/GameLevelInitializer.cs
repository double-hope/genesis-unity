using System.Collections.Generic;
using Player;
using UnityEngine;

namespace Core
{
    public class GameLevelInitializer : MonoBehaviour
    {
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private PlayerAnimations _playerAnimations;
        [SerializeField] private GameUIInputView _gameUIInputView;

        private ExternalDevicesInputReader _externalDevicesInput;
        private PlayerBrain _playerBrain;
        private void Awake()
        {
            _externalDevicesInput = new ExternalDevicesInputReader();
            _playerBrain = new PlayerBrain(_playerController, _playerAnimations, new List<IEntityInputSource>
            {
                _gameUIInputView,
                _externalDevicesInput
            });
        }

        private void FixedUpdate()
        {
            _playerBrain.OnFixedUpdate();
        }
    }
}