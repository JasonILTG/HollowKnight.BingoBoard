using System;
using System.Collections.Generic;
using GlobalEnums;

namespace BingoBoard
{
    [Serializable]
    public class SaveSettings
    {
    }

    public struct Layout
    {
        public Layout(float x, float y)
        {
            enabled = true;
            this.x = x;
            this.y = y;
        }
        public bool enabled;
        public float x;
        public float y;

        public void Deconstruct(out float x, out float y, out bool enabled)
        {
            x = this.x;
            y = this.y;
            enabled = this.enabled;
        }
    }
    
    [Serializable]
    public class GlobalSettings
    {
        public string boardUrl = "";
        public string boardToggle = "Tab";
    }
}