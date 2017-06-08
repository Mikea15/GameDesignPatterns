using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    private int m_health;
    private Breed m_breed;

    public Animal(Breed breed)
    {
        m_breed = breed;
        m_health = breed.GetHealth();
    }

    public string GetAttack( )
    {
        return m_breed.GetAttack();
    }
}
