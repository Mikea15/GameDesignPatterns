using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Subject : MonoBehaviour
{
    // Cheating here a bit.
    public Achievements m_achObserver;

    private List<Observer> m_observers;

    private void Awake()
    {
        m_observers = new List<Observer>();

        AddObserver(m_achObserver);
    }

    public void AddObserver( Observer observer )
    {
        if (!m_observers.Contains(observer))
        {
            m_observers.Add(observer);
        }
    }

    /// <summary>
    /// Removes Observer
    /// </summary>
    /// <param name="observer">Observer to Remove</param>
    /// <returns>Success or not.</returns>
    public bool RemoveObserver( Observer observer )
    {
        return m_observers.Remove(observer);
    }

    public void Notify( GameObject gameObject, EEventType eType )
    {
        for (int i = 0; i < m_observers.Count; i++)
        {
            m_observers[i].OnNotify(gameObject, eType);
        }
    }
}
