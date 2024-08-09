using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 物体持有者
    /// </summary>
    public interface IThingHolder
    {
        IThingHolder ParentHolder { get; }

        void GetChildHolders(List<IThingHolder> outChildren);

        ThingOwner GetDirectlyHeldThings();
    }
}

