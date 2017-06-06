using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeroState
{
    public abstract void HandleInput(HeroineAutomaton hero);

    public abstract void Enter(HeroineAutomaton hero);
    public abstract void Execute(HeroineAutomaton hero);
    public abstract void Exit(HeroineAutomaton hero);
}

public class StandState : HeroState
{
    public override void Enter(HeroineAutomaton hero)
    {
        Debug.Log("Enter Stand State");
    }

    public override void Execute(HeroineAutomaton hero)
    {
        
    }

    public override void Exit(HeroineAutomaton hero)
    {
        Debug.Log("Exit Stand State");
    }

    public override void HandleInput(HeroineAutomaton hero)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            hero.PushState(new FireState());
        }
    }
}

public class FireState : HeroState
{
    public override void Enter(HeroineAutomaton hero)
    {
        Debug.Log("Enter Fire State");
    }

    public override void Execute(HeroineAutomaton hero)
    {
       
    }

    public override void Exit(HeroineAutomaton hero)
    {
        Debug.Log("Exit Fire State");
    }

    public override void HandleInput(HeroineAutomaton hero)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            hero.PopState();
        }
    }
}

public class HeroineAutomaton : MonoBehaviour
{
    private Stack<HeroState> m_states;
    
    public HeroState CurrentState
    {
        get
        {
            if (m_states != null && m_states.Count > 0)
            {
                return m_states.Peek();
            }
            return null;
        }
    }

    private void Awake()
    {
        m_states = new Stack<HeroState>();

        PushState(new StandState());
    }

    private void Update()
    {
        if(CurrentState != null )
        {
            CurrentState.HandleInput(this);
            CurrentState.Execute(this);
        }
    }

    public void ChangeState( HeroState state )
    {
        // 
    }

    public void PushState( HeroState state )
    {
        if( state != null )
        {

            if(CurrentState != null )
            {
                CurrentState.Exit(this);
            }

            m_states.Push(state);

            if (CurrentState != null)
            {
                CurrentState.Enter(this);
            }
        }
    }

    public void PopState( )
    {
        if( m_states.Count > 0 )
        {
            if(CurrentState != null )
            {
                CurrentState.Exit(this);
            }

            m_states.Pop();

            if(CurrentState != null )
            {
                CurrentState.Enter(this);
            }
        }
    }
}
