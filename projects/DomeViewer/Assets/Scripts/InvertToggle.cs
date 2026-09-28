using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvertToggle : MonoBehaviour
{
    public UnityEvent<bool> InvertBoolOnToggled;

    public void Toggle(bool b)
    {
        InvertBoolOnToggled.Invoke(!b);
    }

}
