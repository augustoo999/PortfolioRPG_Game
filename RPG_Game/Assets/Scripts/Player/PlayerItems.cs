using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public int woodPlayer;
    public float waterPlayer;
    private float waterLimit = 50;
    public int carrotPlayer;

    public void WaterLimit(float water)
    {
        if (waterPlayer <= waterLimit)
        {
            waterPlayer += water;
        }
    }
}
