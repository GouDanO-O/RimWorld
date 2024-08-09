using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    public class WorldSpawnStepDef : Def
    {
        public float order;

        public WorldSpawnStep worldSpawnStep;

        public override void PostLoad()
        {
            base.PostLoad();
            worldSpawnStep.def = this;
        }
    }
}

