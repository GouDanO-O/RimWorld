using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RimWorld
{
    public class Editable
    {
        /// <summary>
        /// 解决引用
        /// </summary>
        public virtual void ResolveReferences()
        {

        }

        /// <summary>
        /// 传递加载的数据
        /// </summary>
        public virtual void PostLoad()
        {

        }

        /// <summary>
        /// 报错提示
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> ConfigErrors()
        {
            return Enumerable.Empty<string>();
        }
    }
}

