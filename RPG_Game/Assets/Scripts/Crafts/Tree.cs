using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField]
    private float TreeHp;
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private GameObject woodDrop;
    [SerializeField]
    private int totalWood;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnHit()
    {
        TreeHp--;

        anim.SetTrigger("isHitting");

        if (TreeHp <= 0)
        {
            for (int i = 0; i < totalWood; i++)
            {
                Instantiate(woodDrop, transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), transform.rotation);
            }
            anim.SetTrigger("cut");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Axe"))
        {
            Debug.Log("Acertou");
            OnHit();
        }
    }
}
