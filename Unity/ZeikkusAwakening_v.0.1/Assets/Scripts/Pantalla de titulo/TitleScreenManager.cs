using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
    public Image logobg, logo, titlebg, titlelogo, titlepress;

    private InputManager iMgr;
    private bool titlepressActive;
    private bool titlepressVisible = false;

    private void Start()
    {
        logobg.CrossFadeAlpha(0, 0, true);
        logo.CrossFadeAlpha(0, 0, true);
        titlebg.CrossFadeAlpha(0, 0, true);
        titlelogo.CrossFadeAlpha(0, 0, true);
        titlepress.CrossFadeAlpha(0, 0, true);
        StartCoroutine(AnimateTitleScreen());
    }

    private void OnGUI()
    {
        
    }

    IEnumerator AnimateTitleScreen()
    {
        logobg.CrossFadeAlpha(1, 1, true);
        yield return new WaitForSeconds(1f);
        logo.CrossFadeAlpha(1, 1, true);
        yield return new WaitForSeconds(2f);
        logo.CrossFadeAlpha(0, 1, true);
        yield return new WaitForSeconds(1f);
        logobg.CrossFadeAlpha(0, 1, true);
        yield return new WaitForSeconds(1f);
        titlebg.CrossFadeAlpha(1, 1, true);
        titlelogo.CrossFadeAlpha(1, 1, true);
        yield return new WaitForSeconds(1f);
        titlepress.CrossFadeAlpha(1, 1, true);
        yield return new WaitForSeconds(1f);
        titlepressActive = true;
        titlepressVisible = true;
        StartCoroutine(AnimatePressStart());
    }
    
    IEnumerator AnimatePressStart()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            if (titlepressActive)
            {
                titlepress.CrossFadeAlpha(titlepressVisible ? 0 : 1, 2, true);
                titlepressVisible = !titlepressVisible;
            }
        }
    }
}