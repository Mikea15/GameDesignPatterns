using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLaunch : Superpower
{
    protected override void Activate()
    {
        PlaySound(null, 1f);
        SpawnParticles(null);
        Move(Vector3.up * 100f);
    }
}
