using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField]
    private string[] messageArray;
    [SerializeField]
    private Text messageText;
    [SerializeField]
    private TextWriterSingle textWriter;
    [SerializeField]
    private AudioSource talkingAudioSource;

    private void Awake()
    {
        //find the message text gameobject
        messageText = GameObject.Find("messageText").GetComponent<Text>();
        //find the talkingaudiosource gameobject
        talkingAudioSource = GameObject.Find("TalkingSoundCharacter").GetComponent<AudioSource>();
    }

    private void StartTalkingSound()
    {
        talkingAudioSource.Play();
    }

    private void StopTalkingSound()
    {
        talkingAudioSource.Stop();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!(textWriter != null && textWriter.GetIsActive()))
            {
                //start talking
                string message = messageArray[Random.Range(0, messageArray.Length)];
                StartTalkingSound();
                textWriter = TypeWriter.AddWrite_Static(messageText, message, .3f, true, true, StopTalkingSound);
                
            }
            else
            {
                //Currently active TextWriter
                textWriter.WriteAllandDestroy();
            }
        }
    }

}


