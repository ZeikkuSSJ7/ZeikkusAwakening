using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.Mathematics;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private CinemachineFreeLook cmfl;
    private InputManager inputManager;
    private float originalRadius;
    private InBetweenObjectManager ibom;
    private GameManager gameManager;
    private CinemachineFreeLook.Orbit orbit;
    private void Awake()
    {
        cmfl = GetComponent<CinemachineFreeLook>();
        ibom = FindObjectOfType<InBetweenObjectManager>();
        gameManager = FindObjectOfType<GameManager>();
        Transform player = FindObjectOfType<PlayerManager>().transform;
        cmfl.m_Follow = player;
        cmfl.m_LookAt = player;
        inputManager = player.gameObject.GetComponent<InputManager>();
        originalRadius = cmfl.m_Orbits[1].m_Radius;
        orbit = cmfl.m_Orbits[1];
        ChangeCameraInvert();
    }

    private void Update()
    {
        if (inputManager.lTrigger && !gameManager.inWorld)
        {
            if (ibom.enemyFound)
            {
                orbit.m_Radius = Mathf.Clamp(ibom.distance, 4, Int32.MaxValue);
            } else
            {
                orbit.m_Radius = originalRadius;
            }
        }
    }

    public void ChangeCameraInvert()
    {
        cmfl.m_XAxis.m_InvertInput = GameManager.invertCameraX;
        cmfl.m_YAxis.m_InvertInput = GameManager.invertCameraY;
    }

    public void ChangeTarget(Transform newTarget)
    {
        cmfl.m_Follow = newTarget;
        cmfl.m_LookAt = newTarget;
    }
}
