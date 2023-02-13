using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class _0210_Fade : MonoBehaviour
{
    public Image fadeImage;
    void Start()
    {
        StartCoroutine(FadeOut());                       
    }
    IEnumerator FadeIn()
    {
        Color startColor = fadeImage.color;
        for(int i = 0; i < 100; i++)
        {
            startColor.a += 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator FadeOut()
    {
        Color startColor = fadeImage.color;
        for (int i = 0; i < 100; i++)
        {
            startColor.a -= 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }
    }
    private void Update()
    {
        if (fadeImage.color.a == 0)
        {
            StartCoroutine(FadeIn());
        }
    }
}
