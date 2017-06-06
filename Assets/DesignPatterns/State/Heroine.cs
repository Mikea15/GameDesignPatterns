using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroine : MonoBehaviour
{
    private HeroineState m_state;

	public virtual void HandleInput( Input input )
    {
        HeroineState state = m_state.HandleInput(this, input);
        if( state != null )
        {
            m_state = null;
            m_state = state;

            m_state.Enter(this);
        }
    }

    public virtual void Update( )
    {
        m_state.Update(this);
    }

    // dummy function.
    public void SetImage(int v)
    {
        
    }

    public void SuperBomb()
    {
        Debug.Log("Kaboom");
    }
}
