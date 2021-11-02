using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUIManager : MonoBehaviour
{
    public static GameUIManager Instance;
    [SerializeField] private Text pointsDisplay;
    [SerializeField] private int m_Points = 0;// ENCAPSULATION
    public int Points // ENCAPSULATION
    {
        get { return m_Points; }
        set {
        if (value<0)
        {
            m_Points = 0;
        }else
        {
            m_Points = value;
        }}
    }
    void Awake()
    {
        Instance = this;
    }
    public void UpdatePoints()// ABSTRACTION
    {
        pointsDisplay.text = "Points: " + m_Points;
    }
}
