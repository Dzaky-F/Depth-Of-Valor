using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CutsceneController : MonoBehaviour
{
    public Animator FadeOut;
    public TMP_Text dialogueText;
    public List<string> dialogue;

    int idx = 0;
    string line;

    void Start()
    {
        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        FadeOut.Play("FadeIn");
        yield return new WaitForSeconds(4);
        StartCoroutine(TypeLines(idx));
    }

    IEnumerator TypeLines(int idx)
    {   
        for (int i = 0; i < dialogue[idx].Length; i++)
        {
            dialogueText.text += dialogue[idx][i];
            yield return new WaitForSeconds(0.06f);
        }
        yield return new WaitForSeconds(3);
        NextLine();
    }

    void NextLine()
    {
        idx++;

        if (idx == dialogue.Count) 
        {
            StartCoroutine(ChangeScreen());
            return;
        }

        dialogueText.text = "";
        StartCoroutine(TypeLines(idx));
    }

    IEnumerator ChangeScreen()
    {
        yield return new WaitForSeconds(2);
        FadeOut.Play("FadeOut");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainScene");
    }
}
