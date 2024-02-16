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
            Instantiate(woodDrop, transform.position, transform.rotation);
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
