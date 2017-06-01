using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// will produce warnings when creating Monsters
// because MonoBehaviour has its own constructor..
// Warning:
// You are trying to create a MonoBehaviour using the 'new' keyword.  
// This is not allowed.  
// MonoBehaviours can only be added using AddComponent().  
// Alternatively, your script can inherit from ScriptableObject or 
// no base class at all
// 
public abstract class Monster : MonoBehaviour
{
    public abstract Monster Clone();

    public void SayHello( )
    {
        Debug.Log("hi! I'm " + GetType() );
    }
}

public class Ghost : Monster
{
    public override Monster Clone()
    {
        return new Ghost();
    }
}

public class Demon : Monster
{
    public override Monster Clone()
    {
        return new Demon();
    }
}
