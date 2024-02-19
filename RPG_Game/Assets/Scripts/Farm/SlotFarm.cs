using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{
    [Header("Components")]

    [SerializeField]
    private SpriteRenderer sr;
    [SerializeField]
    private Sprite hole;
    [SerializeField]
    private Sprite carrot;

    [Header("Settings")]
    [SerializeField]
    private int digAmount;
    [SerializeField]
    private bool detecting;
    [SerializeField]
    private float waterForCarrot;
    private int initialDigAmount;
    private float currentWater;
    private bool dugHole;

    PlayerItems playerItems;

    private void Start()
    {
        playerItems = FindObjectOfType<PlayerItems>();
        initialDigAmount = digAmount;
    }

    private void Update()
    {
        if (dugHole)
        {
            if (detecting)
            {
                currentWater += 0.01f;
            }

            if (currentWater >= waterForCarrot)
            {
                sr.sprite = carrot;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    sr.sprite = hole;
                    playerItems.carrotPlayer++;
                    currentWater = 0f;
                }
            }
        }
    }
    public void OnHit()
    {
        digAmount--;

        if (digAmount <= initialDigAmount / 2)
        {
            sr.sprite = hole;
            dugHole = true;
        }

        //if (digAmount <= 0)
        //{
        //    
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dig"))
        {
            OnHit();
        }

        if (collision.CompareTag("Water"))
        {
            detecting = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        detecting = false;
    }
}
