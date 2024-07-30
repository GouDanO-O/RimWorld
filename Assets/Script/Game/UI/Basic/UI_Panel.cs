using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rim_UI
{
    public abstract class UI_Panel : MonoBehaviour
    {
        protected abstract void OnInit();

        protected abstract void OnStart();

        protected abstract void OnShow();

        protected abstract void OnHide();

        protected abstract void OnDestroy();
    }
}

