using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// �ܷ���п���
    /// </summary>
    public interface IStrippable
    {
        bool AnythingToStrip();

        void Strip(bool notifyFaction = true);
    }
}