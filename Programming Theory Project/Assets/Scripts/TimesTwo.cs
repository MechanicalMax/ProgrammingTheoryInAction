using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimesTwo : BaseObject// INHERITANCE
{
    void Start()
    {
        rotSpeed = -.2f;
        Spawn();// ABSTRACTION
    }
    protected override void ChangePoints()// POLYMORPHISM
    {
        GameUIManager.Instance.Points *= 2;
    }
}
