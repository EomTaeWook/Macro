﻿namespace Macro.Models
{
    public enum EventType
    {
        Mouse,
        Keyboard,
        Image,
        RelativeToImage,

        Max
    }
    public enum MouseEventType
    {
        None,
        LeftClick,
        RightClick,
        Drag,

        Max
    }

    public enum RepeatType
    {
        Once,
        Count,
        NoSearch,
        Search,

        Max
    }
}