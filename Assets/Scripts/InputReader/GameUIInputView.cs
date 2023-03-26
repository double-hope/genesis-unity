using UnityEngine;

namespace InputReader
{
    public class GameUIInputView : MonoBehaviour, IEntityInputSource
    {
        [SerializeField] private Joystick _joystick;
        
        public float HorizontalDirection => _joystick.Horizontal;
        public float VerticalDirection => _joystick.Vertical;
        
    }
}