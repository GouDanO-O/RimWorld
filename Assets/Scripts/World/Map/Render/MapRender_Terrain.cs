using System.Collections;
using System.Collections.Generic;
using Unity.Entities.UniversalDelegates;
using UnityEngine;
using UnityEngine.AI;

namespace RimWorld.World
{
    /// <summary>
    /// 地形渲染
    /// </summary>
    public class MapRender_Terrain : MapRender
    {
        public override void InitMapRender(Vector2Int mapSize, Matrix4x4[][] mapMatrices, MaterialPropertyBlock[] mapMatProps,int instancesPerBatch)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                for (int x = 0; x < mapSize.x; x++)
                {
                    int index = y * mapSize.x + x;
                    mapMatrices[index / instancesPerBatch][index % instancesPerBatch] = GroundMatrix(x, y);
                }
            }
        }

        public override void DrawMeshInstanced(Matrix4x4[] mapMatrice, int mapMatriceLength, MaterialPropertyBlock mapMatProp)
        {
            if (mesh && material)
            {
                Graphics.DrawMeshInstanced(mesh, 0, material, mapMatrice,mapMatriceLength,mapMatProp);
            }
        }
      
    }
}


