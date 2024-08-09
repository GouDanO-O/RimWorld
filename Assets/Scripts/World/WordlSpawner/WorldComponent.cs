using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RimWorld.World
{
    public abstract class WorldComponent : IExposable
    {
        public WorldManager worldManager;

        public WorldComponent(WorldManager worldManager)
        {
            this.worldManager = worldManager;
        }

        public virtual void WorldComponentUpdate()
        {

        }

        public virtual void WorldComponentTick()
        {

        }

        public virtual void ExposeData()
        {

        }

        public virtual void FinalizeInit()
        {

        }

    }
}

