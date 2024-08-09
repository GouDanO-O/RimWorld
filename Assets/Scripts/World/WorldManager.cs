using QFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 地图的生成
    /// </summary>
    public class WorldManager : MonoSingleton<WorldManager>
    {
        protected MapRenderManager mapRenderManager;

        // Start is called before the first frame update
        void Start()
        {
            InitWorld();
        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// 初始化世界
        /// </summary>
        protected void InitWorld()
        {
            mapRenderManager=new MapRenderManager();
            mapRenderManager.SpawnMapRender();
        }

        /// <summary>
        /// 更新世界世界
        /// </summary>
        public void UpdateMapRender()
        {
            mapRenderManager.UpdateMapRender();
        }
    }
}
