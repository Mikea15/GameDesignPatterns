using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsSubject : Subject
{
    private float m_timeFalling = 0.0f;
    private float m_maxTimeFalling = 2.0f;

    private void FixedUpdate()
    {
        m_timeFalling += Time.deltaTime;

        if( m_timeFalling > m_maxTimeFalling )
        {
            Notify(this.gameObject, EEventType.Fell_Off_Bridge);
        }
    }
}
