using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool inWorld;
    public GameObject pause;
    public int maru;
    public GameObject[] personajes;

    private InputManager inputManager;

    private void Start()
    {
        inputManager = FindObjectOfType<InputManager>();
    }

    public void Pause()
    {
        pause.SetActive(!pause.activeSelf);
    }
}
