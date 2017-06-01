using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeExample : MonoBehaviour
{
	void Start ()
    {
        // v1 
        Debug.Log("Prototype Pattern.");
        Monster ghostPrototype = new Ghost();
        Spawner ghostSpawner = new Spawner(ghostPrototype);

        Monster m1 = ghostSpawner.SpawnMonster();
        m1.SayHello();

        // v2 
        Debug.Log("Using delegate.");
        Spawner v2GhostSpawner = new Spawner(SpawnGhost);
        Monster m2 = v2GhostSpawner.SpawnMonsterv2();
        m2.SayHello();

        // v3
        Debug.Log("Using Generics.");
        SpawnerAbs v3Spawner = new SpawnerFor<Ghost>();
        Monster m3 = v3Spawner.SpawnMonster();
        m3.SayHello();
    }

    public Monster SpawnGhost( )
    {
        return new Ghost();
    }
}
