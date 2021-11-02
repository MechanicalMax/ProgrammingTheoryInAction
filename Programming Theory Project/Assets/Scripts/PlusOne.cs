using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusOne : BaseObject// INHERITANCE
{
    void Start()
    {
        rotSpeed = .4f;
        Spawn();// ABSTRACTION
    }
    protected override void ChangePoints()// POLYMORPHISM
    {
        GameUIManager.Instance.Points += 1;
    }
}
