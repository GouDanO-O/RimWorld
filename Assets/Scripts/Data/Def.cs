using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RimWorld
{
    public class Def : Editable
    {
        [Description("这个Def的名称。它被游戏代码用作标识符")]
        [NoTranslate]
        public string defName = "UnnamedDef";

        [Description("一个标签，用于在游戏中识别它")]
        [DefaultValue(null)]
        [MustTranslate]
        public string label;

        [Description("当玩家检查Def时给出的描述")]
        [DefaultValue(null)]
        [MustTranslate]
        public string description;
    }
}

