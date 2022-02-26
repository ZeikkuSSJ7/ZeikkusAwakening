using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Cutscene1Manager : CutsceneManager
{
    private AnimatorManager animatorManager;
    private InputManager inputManager;
    private HUDManager hudManager;
    private bool gotSword;
    public Image blackFade;
    public Texture faceEyesOpen;
    public SkinnedMeshRenderer face;
    public AudioSource musicSource;
    public AudioMixer mixer;
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        animatorManager = FindObjectOfType<AnimatorManager>();
        inputManager = animatorManager.GetComponent<InputManager>();
        hudManager = FindObjectOfType<HUDManager>();
        dialogue.gameObject.SetActive(true);
        animatorManager.transform.rotation = Quaternion.identity;
        animatorManager.animator.CrossFade("Sleeping", 0);
        inputManager.inDialogue = true;
        musicSource.Stop();
        mixer.SetFloat("EnemiesSFXVolume", -80);
        mixer.SetFloat("EnvironmentSFXVolume", -80);
    }


    public override void DoStuff()
    {
        switch (dialogueCount)
        {
            case 1:
                Material[] materials = face.materials;
                materials[1].mainTexture = faceEyesOpen;
                break;
            case 5:
                StartCoroutine(ChangeCameraAndGetUp());
                break;
            case 7:
                cameras[1].SetActive(false);
                cameras[2].SetActive(true);
                break;
            case 12:
                cameras[2].SetActive(false);
                cameras[3].SetActive(true);
                break;
            case 13:
                StartCoroutine(GetSwordAndShow());
                gotSword = true;
                break;
            case 16:
                FindObjectOfType<HUDManager>().WinBattleAnimation();
                gotSword = false;
                break;
            case 17:
                StartCoroutine(FadeToBlack());
                break;
        }
    }

    public override void EndCutScene()
    {
        if (endingCutscene) return;
        endingCutscene = true;
        if (gotSword)
            hudManager.WinBattleAnimation();
        Material[] materials = face.materials;
        materials[1].mainTexture = faceEyesOpen;
        face.materials = materials;
        foreach (GameObject camera in cameras)
        {
            camera.SetActive(false);
        }

        GameManager.currentDialogue = 18;
        GameManager.currentEvent = 3;
        dialogue.gameObject.SetActive(false);
        StartCoroutine(FadeToBlack());
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
        hudManager.StartBattleAnimation();
        yield return new WaitForSeconds(2f);
        dialogue.gameObject.SetActive(true);
    }

    private IEnumerator FadeToBlack()
    {
        blackFade.CrossFadeAlpha(1,1,true);
        yield return new WaitForSeconds(1f);
        animatorManager.PlayTargetAnimation("Empty", false);
        cameras[3].SetActive(false);
        cameras[4].SetActive(true);
        hudManager.GetCamera();
        yield return new WaitForSeconds(1f);
        inputManager.inDialogue = false;
        mixer.SetFloat("EnemiesSFXVolume", 0);
        mixer.SetFloat("EnvironmentSFXVolume", 0);
        musicSource.Play();
        blackFade.CrossFadeAlpha(0,1,true);
        tutorial.SetActive(true);
    }
}