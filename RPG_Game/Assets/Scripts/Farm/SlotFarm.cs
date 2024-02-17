using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{
    [SerializeField]
    private Sprite hole;
    [SerializeField]
    private Sprite carrot;
    [SerializeField]
    private int digAmount;
    [SerializeField]
    private SpriteRenderer sr;
    private int initialDigAmount;

    private void Start()
    {
        initialDigAmount = digAmount;
    }
    public void OnHit()
    {
        digAmount--;

        if (digAmount <= initialDigAmount / 2)
        {
            sr.sprite = hole;
        }

        //if (digAmount <= 0)
        //{
        //    sr.sprite = carrot;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dig"))
        {
            OnHit();
        }
    }
}
