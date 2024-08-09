using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld
{
    public interface ISignalReceiver
    {
        void Notify_SignalReceived(/*Signal signal*/);
    }
}
