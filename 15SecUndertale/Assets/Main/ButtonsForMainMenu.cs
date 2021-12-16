using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsForMainMenu : MonoBehaviour
{
    public void SimplePixel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HighDefinition()
    {
        SceneManager.LoadScene("HDVersion");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
