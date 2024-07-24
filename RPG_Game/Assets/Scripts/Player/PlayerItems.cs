using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    [Header("Amount")]
    public int woodPlayer;
    public float waterPlayer;
    public int carrotPlayer;
    public int fishes;

    [Header("Limits")]
    [SerializeField]
    private float waterLimit = 20;
    [SerializeField]
    private float carrotLimit = 10;
    [SerializeField]
    private float woodLimit = 5;
    [SerializeField]
    private float fishesLimit = 3f;


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
    public float _FishesLimit 
    { get => fishesLimit; 
      set => fishesLimit = value; 
    }

    public void WaterLimit(float water)
    {
        if (waterPlayer <= waterLimit)
        {
            waterPlayer += water;
        }
    }
}
