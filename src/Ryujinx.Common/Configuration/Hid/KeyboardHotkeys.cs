﻿namespace Ryujinx.Common.Configuration.Hid
{
    // NOTE: Please don't change this to struct.
    //       This breaks Avalonia's TwoWay binding, which makes us unable to save new KeyboardHotkeys.
    public class KeyboardHotkeys
    {
        public Key ToggleVsync { get; set; }
        public Key Screenshot { get; set; }
        public Key ShowUi { get; set; }
        public Key Pause { get; set; }
        public Key ToggleMute { get; set; }
        public Key ResScaleUp { get; set; }
        public Key ResScaleDown { get; set; }
        public Key VolumeUp { get; set; }
        public Key VolumeDown { get; set; }
        public Key ToggleFastForward { get; set; }
        public Key ToggleTurbo { get; set; }
    }
}