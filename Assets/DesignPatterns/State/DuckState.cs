using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckState : StandingState
{
    private float m_chargeTime;
    private float m_maxChargeTime = 2.0f;

    public override void Enter(Heroine hero)
    {
        throw new NotImplementedException();
    }

    public override void Exit(Heroine hero)
    {
        throw new NotImplementedException();
    }

    public override HeroineState HandleInput(Heroine hero, Input input)
    {
        if( Input.GetKeyUp(KeyCode.C) )
        {
            return new StandingState();
        }
        else
        {
            return base.HandleInput(hero, input);
        }
    }

    public override void Update(Heroine hero)
    {
        m_chargeTime += Time.deltaTime;
        if( m_chargeTime > m_maxChargeTime )
        {
            hero.SuperBomb();
        }
    }
}
