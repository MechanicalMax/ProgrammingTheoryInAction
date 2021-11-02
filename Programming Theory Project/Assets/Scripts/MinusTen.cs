using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusTen : BaseObject// INHERITANCE
{
    void Start()
    {
        rotSpeed = .75f;
        Spawn();// ABSTRACTION
    }
    protected override void ChangePoints()// POLYMORPHISM
    {
        GameUIManager.Instance.Points -= 10;
    }
}
