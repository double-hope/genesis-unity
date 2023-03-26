using Core.Services.Updater;
using UnityEngine;

namespace  InputReader
{
    public class ExternalDevicesInputReader : IEntityInputSource
    {
        public float HorizontalDirection => Input.GetAxisRaw("Horizontal");
        public float VerticalDirection => Input.GetAxisRaw("Vertical");
         
    }

}
