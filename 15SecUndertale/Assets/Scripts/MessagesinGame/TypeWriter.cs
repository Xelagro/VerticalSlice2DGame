using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    private static TypeWriter instance;
    private List<TextWriterSingle> textWriterSingleList;

    private void Awake()
    {
        instance = this;
        textWriterSingleList = new List<TextWriterSingle>();
    }

    public static TextWriterSingle AddWrite_Static(Text uiTexting, string textToWriting, float timePerCharacters, bool Invisible, bool removeBeforeAdd, Action onComplete)
    {
        if (removeBeforeAdd)
        {
            instance.RemoveWriter(uiTexting);
        }
        return instance.AddWrite(uiTexting, textToWriting, timePerCharacters, Invisible, onComplete);
    }

    private TextWriterSingle AddWrite(Text uiTexting, string textToWriting, float timePerCharacters, bool Invisible, Action onComplete)
    {
        TextWriterSingle textWriterSingle = new TextWriterSingle(uiTexting, textToWriting, timePerCharacters, Invisible, onComplete);
        textWriterSingleList.Add(textWriterSingle);
        return textWriterSingle;

    }

    public static void RemoveWriter_Static(Text uiText)
    {
        instance.RemoveWriter(uiText);
    }

    public void RemoveWriter(Text uiText)
    {
        for(int i = 0; i < textWriterSingleList.Count; i++)
        {
            if (textWriterSingleList[i].getUIText() == uiText)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }


    private void Update()
    {
        for(int i = 0; i<textWriterSingleList.Count; i++)
        {
            bool destroyInstance = textWriterSingleList[i].Update();
            if (destroyInstance)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }

    
}

