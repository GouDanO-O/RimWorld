using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
public struct Spawner : IComponentData
{
    public Entity Prefab;

    public Vector3 SpawnPos;

    public float NextSpawnTime;

    public float SpawnRate;
}
