using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{


    [SerializeField]
    private bool detectingPlayer;
    private PlayerItems player;

    void Start()
    {
        player = FindObjectOfType<PlayerItems>();
    }

    void Update()
    {
        if (detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            detectingPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            detectingPlayer = false;
        }

    }
}
