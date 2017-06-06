using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EEventType
{
    Fell_Off_Bridge,
    Jump_100_Times
};

public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(GameObject gameObject, EEventType e);
}
