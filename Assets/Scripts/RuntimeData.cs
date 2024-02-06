using Leopotam.Ecs;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeData
{
    public List<EcsEntity> round1Enemies = new List<EcsEntity>(); 
    public List<EcsEntity> round2Enemies = new List<EcsEntity>(); 
    public List<EcsEntity> round3Enemies = new List<EcsEntity>();
    public List<EcsEntity> round4Enemies = new List<EcsEntity>();
    public List<EcsEntity> round5Enemies = new List<EcsEntity>();
}