using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    public enum ThingPlaceMode : byte
    {
        Direct,
        Near
    }

    public class Thing : IExposable, ISelectable
    {
        public void ExposeData()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Gizmos> GetGizmos()
        {
            throw new System.NotImplementedException();
        }

        public string GetInspectString()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<InspectTabBase> GetInspectTabs()
        {
            throw new System.NotImplementedException();
        }
    }
}
