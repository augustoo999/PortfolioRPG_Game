using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName = "Dialogue Created", menuName = "New Dialogue/Create Dialogue")]
public class DialogueSystem : ScriptableObject
{
    [Header("Dialogue System Settings")]
    public GameObject actor;

    [Header("Dialogue")]
    public Sprite speaker;
    public string sentence;

    public List<Sentences> dialogues = new List<Sentences>();
}

[System.Serializable]
public class Sentences
{
    public string actorName;
    public Sprite ProfilePhoto;
    public Languages sentence;
}

[System.Serializable]
public class Languages
{
    public string portuguese;
    public string english;
    public string spanish;
}

#if UNITY_EDITOR
[CustomEditor(typeof(DialogueSystem))]

public class BuilderEditor: Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DialogueSystem ds = (DialogueSystem)target;

        Languages lang = new Languages();
        lang.portuguese = ds.sentence;

        Sentences sent = new Sentences();
        sent.ProfilePhoto = ds.speaker;
        sent.sentence = lang;

        if (GUILayout.Button("Create Dialogue"))
        {
            if (ds.sentence != "")
            {
                ds.dialogues.Add(sent);

                ds.speaker = null;
                ds.sentence = "";
            }
        }
    }
}

#endif
