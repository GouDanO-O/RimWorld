using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld
{
    /// <summary>
    /// 获取物体的加载ID
    /// </summary>
    public interface ILoadReferenceable
    {
        string GetUniqueLoadID();
    }
}
