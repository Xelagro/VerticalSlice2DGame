using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueForShop : MonoBehaviour
{
    private AudioSource TypeSound;
    public Text DialogueText;
    private Queue<string> Sentences;
    public GameObject DialogueUI;
    public Dialogue DialogueStart;

    // Start is called before the first frame update
    void Start()
    {
        TypeSound = GetComponent<AudioSource>();
        Sentences = new Queue<string>();
        StartDialogue(DialogueStart);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        Debug.Log("Yeeeh");
        string sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        TypeSound.Play();
        // PLAYS SOUND AT THE START
        DialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(.1f);
            yield return null;
        }
        TypeSound.Stop();
        // STOPS THE SOUND AS SOON AS THE TEXT STOPS ANIMATING

    }

    void EndDialogue()
    {
        Debug.Log("END CONVERSATION");
        DialogueUI.SetActive(false);
    }
}
