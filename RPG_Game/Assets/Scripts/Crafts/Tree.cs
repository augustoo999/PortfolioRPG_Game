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
    [SerializeField]
    private ParticleSystem leafsParticles;
    private bool isCut;

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
        leafsParticles.Play();

        if (TreeHp == 0)
        {
            for (int i = 0; i < totalWood; i++)
            {
                Instantiate(woodDrop, transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), transform.rotation);
            }
            anim.SetTrigger("cut");
            isCut = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Axe") && !isCut)
        {
            Debug.Log("Acertou");
            OnHit();
        }
    }
}
