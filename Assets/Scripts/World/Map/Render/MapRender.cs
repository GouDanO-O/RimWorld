using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld.World
{
    /// <summary>
    /// 基础地图渲染块
    /// </summary>
    public abstract class MapRender
    {
        public Mesh mesh;

        public Material material;

        /// <summary>
        /// 初始化
        /// </summary>
        public abstract void InitMapRender(Vector2Int mapSize, Matrix4x4[][] mapMatrices, MaterialPropertyBlock[] mapMatProps, int instancesPerBatch);

        /// <summary>
        /// 这个方法根据地块的位置 (x, y) 生成一个变换矩阵。每个地块被放置在对应的 (x + 0.5, 0, y + 0.5) 的位置，并可能被旋转 180 度
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        protected virtual Matrix4x4 GroundMatrix(int x, int y)
        {
            Vector3 pos = new Vector3(x + 0.5f, 0f, y + 0.5f);
            float zRot = Random.Range(0, 2) * 180f;
            return Matrix4x4.TRS(pos, Quaternion.Euler(90f, 0f, zRot), Vector3.one);
        }

        /// <summary>
        /// 绘制
        /// </summary>
        public abstract void DrawMeshInstanced(Matrix4x4[] mapMatrice,int mapMatriceLength, MaterialPropertyBlock mapMatProp);
    }
}

