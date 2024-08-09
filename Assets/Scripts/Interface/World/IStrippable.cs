using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 能否进行开采
    /// </summary>
    public interface IStrippable
    {
        bool AnythingToStrip();

        void Strip(bool notifyFaction = true);
    }
}