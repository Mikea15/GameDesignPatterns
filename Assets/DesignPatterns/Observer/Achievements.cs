using System;
using UnityEngine;

public enum EAchievementType
{
    Fell_Off_Bridge,
};

public class Achievements : Observer
{
    private bool[] m_achievementsUnclocked;

    private void Awake()
    {
        m_achievementsUnclocked = new bool[2] { false, false };
    }

    public override void OnNotify(GameObject gameObject, EEventType e)
    {
        switch( e )
        {
            case EEventType.Fell_Off_Bridge:
                if( true /* some condition met */ && !m_achievementsUnclocked[(int) EAchievementType.Fell_Off_Bridge] )
                {
                    Unlock(EAchievementType.Fell_Off_Bridge);
                }
                break;
            case EEventType.Jump_100_Times:
                break;
            default: break;
        }
    }

    private void Unlock( EAchievementType ach )
    {
        Debug.Log("Unlocked Achievement: " + ach);

        m_achievementsUnclocked[(int)EAchievementType.Fell_Off_Bridge] = true;
    }


}
