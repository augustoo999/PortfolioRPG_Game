using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public float dialogueRange;
    public LayerMask playerLayer;
    public DialogueSystem dialogue;
    bool playerHit;
    private List<string> sentences = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        GetNPCInfo();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerHit)
        {
            DialogueController.instance.Speech(sentences.ToArray());
        }
    }

    void GetNPCInfo()
    {
        for (int i = 0; i < dialogue.dialogues.Count; i++)
        {
            switch (DialogueController.instance.language)
            {
                case DialogueController.idiom.pt:
                    sentences.Add(dialogue.dialogues[i].sentence.portuguese);

                    break;

                case DialogueController.idiom.eng:
                    sentences.Add(dialogue.dialogues[i].sentence.english);

                    break;

                case DialogueController.idiom.span:
                    sentences.Add(dialogue.dialogues[i].sentence.spanish);

                    break;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ShowDialogue();
    }

    public void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);
        if (hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }

}
