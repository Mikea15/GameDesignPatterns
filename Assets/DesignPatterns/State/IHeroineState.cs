using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public interface IHeroineState
// {
//     void HandleInput(Heroine hero, Input input);
//     void Update(Heroine hero);
// }

public abstract class HeroineState
{
    // public static StandingState standing;
    // public static DuckState duck;
    // public static JumpingState jumping;
    // public static DivingState diving;

    public abstract HeroineState HandleInput(Heroine hero, Input input);

    public abstract void Enter(Heroine hero);
    public abstract void Update(Heroine hero);
    public abstract void Exit(Heroine hero);
}