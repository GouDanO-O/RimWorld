using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    public abstract class WorldSpawnStep
    {
        public WorldSpawnStepDef def;

        public abstract int SeedPart { get; }

        public abstract void GenerateFresh(string seed);

        public virtual void GenerateWithoutWorldData(string seed)
        {
            GenerateFresh(seed);
        }

        public virtual void GenerateFromScribe(string seed)
        {

        }
    }
}

