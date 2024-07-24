using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    [SerializeField]
    private bool detectingPlayer;
    [SerializeField]
    private PlayerItems player;
    [SerializeField]
    private int percentage;
    private PlayerAnim playerAnim;
    [SerializeField]
    private GameObject fishPrefab;

    void Start()
    {
        player = FindObjectOfType<PlayerItems>();
        playerAnim = player.GetComponent<PlayerAnim>();
    }

    void Update()
    {
        if (detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            playerAnim.OnCastingStarted();
        }
    }

    public void OnCasting()
    {
         int randomValue = Random.Range(1, 100);

        if (randomValue <= percentage)
        {
            // conseguiu pescar
            Instantiate(fishPrefab, player.transform.position + new Vector3(Random.Range(-2, -1), 0f, 0f), Quaternion.identity);
        }
        else
        {
            Debug.Log("Não pescou");
            //pescou vento
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
