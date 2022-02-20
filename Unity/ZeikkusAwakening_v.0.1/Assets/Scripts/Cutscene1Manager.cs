using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene1Manager : CutsceneManager
{
    private AnimatorManager animatorManager;
    private InputManager inputManager;
    public Image blackFade;

    // Start is called before the first frame update
    void Start()
    {
        animatorManager = FindObjectOfType<AnimatorManager>();
        inputManager = animatorManager.GetComponent<InputManager>();
        dialogue.gameObject.SetActive(true);
        animatorManager.transform.rotation = Quaternion.identity;
        animatorManager.animator.CrossFade("Sleeping", 0);
        inputManager.inDialogue = true;
    }


    public override void DoStuff()
    {
        Debug.Log(dialogueCount);
        switch (dialogueCount)
        {
            case 5:
                StartCoroutine(ChangeCameraAndGetUp());
                break;
            case 8:
                cameras[1].SetActive(false);
                cameras[2].SetActive(true);
                break;
            case 12:
                cameras[2].SetActive(false);
                cameras[3].SetActive(true);
                break;
            case 13:
                StartCoroutine(GetSwordAndShow());
                break;
            case 14:
                animatorManager.PlayTargetAnimation("sword_idle", false);
                break;
            case 17:
                StartCoroutine(FadeToBlack());
                break;
            default:
                break;
        }
    }

    private IEnumerator ChangeCameraAndGetUp()
    {
        cameras[0].SetActive(false);
        cameras[1].SetActive(true);
        yield return new WaitForSeconds(1.8f);
        animatorManager.PlayTargetAnimation("Get Up", false);
    }

    private IEnumerator GetSwordAndShow()
    {
        animatorManager.PlayTargetAnimation("Get Sword", false);
        yield return new WaitForSeconds(2f);
        dialogue.gameObject.SetActive(true);
    }

    private IEnumerator FadeToBlack()
    {
        blackFade.CrossFadeAlpha(0,1,true);
        yield return new WaitForSeconds(1f);
    }
}