using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : HeroineState
{
    public override void Enter(Heroine hero)
    {
        hero.SetImage(1);
    }

    public override void Exit(Heroine hero)
    {
        throw new NotImplementedException();
    }

    public override HeroineState HandleInput(Heroine hero, Input input)
    {
        // testing.
        if( 1 == 1 )
        {
            return new DuckState();
        }
        return null;
    }

    public override void Update(Heroine hero)
    {
        throw new NotImplementedException();
    }
}
