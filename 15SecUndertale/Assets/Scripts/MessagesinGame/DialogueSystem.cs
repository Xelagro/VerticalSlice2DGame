using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField]
    private string[] messageArray;
    private Text messageText;
    private TextWriterSingle textWriter;
    private AudioSource talkingAudioSource;

    private void Awake()
    {
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();
        talkingAudioSource = transform.Find("TalkingSound").GetComponent<AudioSource>();
        if (Input.GetKeyDown("z"))
        {
            if (textWriter != null && textWriter.IsActive())
            {
                //Currently active TextWriter
                textWriter.WriteAllandDestroy();
            }
            else
            {
                string message = messageArray[Random.Range(0, messageArray.Length)];
                StartTalkingSound();
                textWriter = TypeWriter.AddWrite_Static(messageText, message, .1f, true, true, StopTalkingSound);
            }
        }
    }

    private void StartTalkingSound()
    {
        talkingAudioSource.Play();
    }

    private void StopTalkingSound()
    {
        talkingAudioSource.Stop();
    }

    private void Start()
    {
        //TypeWriter.AddWrite_Static(messageText, "", .3f, true);
    }
}


