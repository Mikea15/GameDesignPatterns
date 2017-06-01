using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate Monster SpawnCallback();

public class Spawner
{
    /// <summary>
    /// First Method.
    /// </summary>
    private Monster m_prototype;
    
    public Spawner(Monster prototype)
    {
        m_prototype = prototype;
    }
    
    public Monster SpawnMonster( )
    {
        return m_prototype.Clone();
    }

    /// <summary>
    /// Second Method.
    /// With Delegate
    /// </summary>
    private SpawnCallback m_spawn;

    public Spawner(SpawnCallback spawn)
    {
        m_spawn = spawn;
    }

    public Monster SpawnMonsterv2( )
    {
        return m_spawn();
    }
}


/// <summary>
/// Third Method using Generics.
/// </summary>
public abstract class SpawnerAbs
{
    public abstract Monster SpawnMonster();
}


public class SpawnerFor<T> : SpawnerAbs 
    where T : Monster, new()
{

    public override Monster SpawnMonster()
    {
        return new T();
    }
}
