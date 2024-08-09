using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 能否被选择
    /// </summary>
    public interface ISelectable
    {
        IEnumerable<Gizmos> GetGizmos();

        string GetInspectString();

        IEnumerable<InspectTabBase> GetInspectTabs();
    }
}

