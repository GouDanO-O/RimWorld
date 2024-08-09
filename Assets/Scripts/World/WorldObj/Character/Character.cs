using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    public class Character : ISelectable, IRenameable
    {
        public string RenamableLabel { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string BaseLabel => throw new System.NotImplementedException();

        public string InspectLabel => throw new System.NotImplementedException();

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
