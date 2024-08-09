using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 当有特殊事件时,减速游戏时间
    /// </summary>
    public class TimeSlower
    {
        private int forceNormalSpeedUntil;

        private const int ForceTicksStandard = 800;

        private const int ForceTicksShort = 240;

        public bool ForcedNormalSpeed
        {
            get
            {
                return false;
            }
        }

        public void SignalForceNormalSpeed()
        {
            
        }

        public void SignalForceNormalSpeedShort()
        {
            
        }
    }
}

