using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.Mission
{
    public class Mission : IExposable, ILoadReferenceable, ISignalReceiver
    {
        public string GetUniqueLoadID()
        {
            throw new System.NotImplementedException();
        }

        public void Notify_SignalReceived()
        {
            throw new System.NotImplementedException();
        }

        void IExposable.ExposeData()
        {
            throw new System.NotImplementedException();
        }
    }
}

