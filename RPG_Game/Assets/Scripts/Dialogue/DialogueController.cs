using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [System.Serializable]
    public enum idiom
    {
        pt,
        eng,
        span
    }

    public idiom language;

    [Header("Components")]
    public GameObject dialogueObj; //janela do dialogo
    public Image profileSprite; //sprite do perfil
    public TextMeshProUGUI speakText; //texto da fala
    public Text actorName; //nome do actor que está falando

    [Header("Settings")]
    public float speedText;

    //variaveis de controle
    private bool isShowing;
    private int index; //index de falas
    private string[] sentences;

    public static DialogueController instance;

    public bool IsShowing { get => isShowing; set => isShowing = value; }

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speakText.text += letter;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void NextSentence()
    {
        if (speakText.text == sentences[index])
        {
            if (index < sentences.Length - 1)
            {
                index++;
                speakText.text = "";
                StartCoroutine(TypeSentence());
            }
            else
            {
                speakText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                sentences = null;
                IsShowing = false;
            }
        }
    }

    public void Speech(string[] txt)
    {
        if (!IsShowing)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            IsShowing = true;
        }
    }
}
