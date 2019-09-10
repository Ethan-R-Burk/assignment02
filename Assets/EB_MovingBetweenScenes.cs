using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EB_Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Playing_EB");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit_EB");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro_EB");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}