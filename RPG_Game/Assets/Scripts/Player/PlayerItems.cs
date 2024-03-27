using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    [Header("Amount")]
    public int woodPlayer;
    public float waterPlayer;
    public int carrotPlayer;

    [Header("Limits")]
    [SerializeField]
    private float waterLimit = 20;
    [SerializeField]
    private float carrotLimit = 10;
    [SerializeField]
    private float woodLimit = 5;

    public float _WaterLimit 
    { 
        get => waterLimit; 
        set => waterLimit = value; 
    }
    public float _CarrotLimit 
    { 
        get => carrotLimit; 
        set => carrotLimit = value; 
    }
    public float _WoodLimit 
    { 
        get => woodLimit; 
        set => woodLimit = value; 
    }

    public void WaterLimit(float water)
    {
        if (waterPlayer <= waterLimit)
        {
            waterPlayer += water;
        }
    }
}
