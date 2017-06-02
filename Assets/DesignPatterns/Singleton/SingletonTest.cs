using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    private void Start()
    {
        FileSystem ps3Fs = FileSystem.Instance();
        Debug.Log(ps3Fs.GetType());

    }
}
