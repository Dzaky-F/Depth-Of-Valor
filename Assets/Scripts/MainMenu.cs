using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator FadeOut;
    public AudioClip musicClip;
    public AudioSource musicSource;
    
    public void StartGame()
    {
        StartCoroutine(ChangeScreen());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator ChangeScreen()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
        FadeOut.Play("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Cutscene");
    }
    
}
