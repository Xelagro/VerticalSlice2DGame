using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriterSingle : TypeWriter
{
    private Text uiText;
    private string textToWrite;
    private int characterIndex;
    private float timePerCharacter;
    private float timer;
    private bool invisibleCharacters;
    private Action onComplete;

    public TextWriterSingle(Text uiTexting, string textToWriting, float timePerCharacters, bool Invisible, Action onCompleted)
    {
        TextWriterSingle textWriterSingle = this;
        textWriterSingle.uiText = uiTexting;
        textWriterSingle.textToWrite = textToWriting;
        textWriterSingle.timePerCharacter = timePerCharacters;
        textWriterSingle.invisibleCharacters = Invisible;
        textWriterSingle.onComplete = onCompleted;
        characterIndex = 0;
    }

    public bool Update
    {
        get
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                //display next character
                timer += timePerCharacter;
                characterIndex++;
                string text = textToWrite.Substring(0, characterIndex);
                if (invisibleCharacters)
                {
                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                }

                uiText.text = text;

                if (characterIndex >= textToWrite.Length)
                {
                    //Entire string displayed
                    uiText = null;
                    if (onComplete != null) onComplete();
                    return true;
                }
            }
            return false;
        }
    }

    public Text GetUIText()
    {
        return uiText;
    }

    public bool GetIsActive()
    {
        return characterIndex < textToWrite.Length;
    }

    public void WriteAllandDestroy()
    {
        uiText.text = textToWrite;
        characterIndex = textToWrite.Length;
        if (onComplete != null) onComplete();
        TypeWriter.RemoveWriter_Static(uiText);
    }
}
