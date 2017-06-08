using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Superpower
{
    protected abstract void Activate();

    protected void Move(Vector3 delta)
    {

    }

    protected void PlaySound(AudioClip clip, float volume)
    {

    }

    protected void SpawnParticles(ParticleSystem ps)
    {

    }


}
