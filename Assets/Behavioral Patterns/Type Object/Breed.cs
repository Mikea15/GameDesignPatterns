using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breed
{
    private int m_health;
    private string m_attack;

    public Breed(int health, string attack)
    {
        m_attack = attack;
        m_health = health;
    }

    public int GetHealth( )
    {
        return m_health;
    }

    public string GetAttack( )
    {
        return m_attack;
    }
}
