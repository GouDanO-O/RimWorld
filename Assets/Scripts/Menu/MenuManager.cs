using QFramework;
using RimWorld.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld
{
    public class MenuManager : MonoSingleton<MenuManager>
    {
        private void Awake()
        {
            
        }

        private void Start()
        {
            ToolLists.Instance.SpawnUI_Async<UI_Menu>(UILevel.Common, () =>
            {
                ShowMenuUIOver();
            });
        }

        /// <summary>
        /// 显示菜单完毕
        /// </summary>
        protected void ShowMenuUIOver()
        {
            
        }

        /// <summary>
        /// 移除场景UI
        /// </summary>
        public void RemoveMenuUI()
        {

        }
    }
}
