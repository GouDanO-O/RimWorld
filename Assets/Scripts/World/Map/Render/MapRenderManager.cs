using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    public class MapRenderManager
    {
        protected MapRender_Terrain mapRender_Terrain;

        /// <summary>
        /// 地图尺寸
        /// </summary>
        public Vector2Int mapSize = Vector2Int.one;

        /// <summary>
        /// 存储了地图中每个地块的变换矩阵
        /// </summary>
        private Matrix4x4[][] mapMatrices;

        /// <summary>
        /// 材质属性块数组，用于动态控制每批次地块的材质属性
        /// </summary>
        private MaterialPropertyBlock[] mapMatProps;

        /// <summary>
        /// 每批次可以实例化渲染的最大地块数
        /// </summary>
        public const int instancesPerBatch = 1023;

        /// <summary>
        /// 生成地图渲染块
        /// </summary>
        public void SpawnMapRender()
        {
            if (mapSize.x <= 0 || mapSize.y <= 0)
                return;

            int tileCount = mapSize.x * mapSize.y;

            mapMatrices = new Matrix4x4[Mathf.CeilToInt((float)tileCount / instancesPerBatch)][];
            mapMatProps = new MaterialPropertyBlock[mapMatrices.Length];

            for (int i = 0; i < mapMatrices.Length; i++)
            {
                mapMatProps[i] = new MaterialPropertyBlock();
                if (i < mapMatrices.Length - 1)
                {
                    mapMatrices[i] = new Matrix4x4[instancesPerBatch];
                }
                else
                {
                    mapMatrices[i] = new Matrix4x4[tileCount - i * instancesPerBatch];
                }
            }

            mapRender_Terrain = new MapRender_Terrain();
            mapRender_Terrain.InitMapRender(mapSize, mapMatrices, mapMatProps,instancesPerBatch);
        }

        /// <summary>
        /// 更新地图渲染块
        /// </summary>
        public void UpdateMapRender()
        {
            for (int i = 0; i < mapMatrices.Length; i++)
            {
                mapRender_Terrain.DrawMeshInstanced(mapMatrices[i], mapMatrices[i].Length, mapMatProps[i]);
            }
        }
    }
}

