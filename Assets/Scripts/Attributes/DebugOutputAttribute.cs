using System;

namespace RimWorld
{
    /// <summary>
    /// Debug特性
    /// </summary>
    public class DebugOutputAttribute : Attribute
    {
        public string name;

        /// <summary>
        /// 类别
        /// </summary>
        public string category = "General";

        /// <summary>
        /// 是否在游戏中开启
        /// </summary>
        public bool onlyWhenPlaying;

        public DebugOutputAttribute()
        {

        }

        public DebugOutputAttribute(bool onlyWhenPlaying)
        {
            this.onlyWhenPlaying = onlyWhenPlaying;
        }

        public DebugOutputAttribute(string category, bool onlyWhenPlaying = false) : this(onlyWhenPlaying)
        {
            this.category = category;
        }
    }
}

