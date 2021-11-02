using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour
{
    protected float rotSpeed; // revolutions per second
    void Update()
    {
        Rotate();
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangePoints();// ABSTRACTION
            GameUIManager.Instance.UpdatePoints();// ABSTRACTION
        }
    }    
    protected void Spawn()// ABSTRACTION
    {
        transform.position = new Vector3(Random.Range(-3f,3f),transform.position.y,Random.Range(-1.75f,1.75f));
    }

    protected void Rotate()// ABSTRACTION
    {
        Vector3 rotation = new Vector3(0,360f*rotSpeed*Time.deltaTime,0);
        transform.Rotate(rotation);
    }

    protected abstract void ChangePoints();// POLYMORPHISM
}
