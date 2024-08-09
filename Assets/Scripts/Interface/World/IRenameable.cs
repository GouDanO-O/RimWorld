using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 重命名
    /// </summary>
    public interface IRenameable
    {
        string RenamableLabel { get; set; }

        string BaseLabel { get; }

        string InspectLabel { get; }
    }
}

