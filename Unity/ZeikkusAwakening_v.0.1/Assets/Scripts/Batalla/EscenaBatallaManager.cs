using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EscenaBatallaManager : MonoBehaviour
{
    public GameObject[] spawners;
    public Transform playerSpawn;
    [NonSerialized] public GameObject enemyToSpawn;
    [NonSerialized] public Vector3 playerOrigin;
    [NonSerialized] public Stats[] enemies;
    private bool battling;
    private Transform playerTransform;

    public int danoTotal;
    public float tiempoDeCombate;
    public int enemyAdvantage;

    private void Update()
    {
        if (GameManager.inPause || !battling) return;
        tiempoDeCombate += Time.deltaTime;
    }

    public void ControlScene()
    {
        battling = true;
        playerTransform = FindObjectOfType<PlayerManager>().transform;
        playerOrigin = playerTransform.position;
        playerTransform.position = playerSpawn.position;
        
        for (int i = 0; i < Random.Range(1, 4); i++)
        {
            Transform spawner = spawners[i].transform;
            Instantiate(enemyToSpawn, spawner.position, spawner.rotation, spawner);
        }
        enemies = GetComponentsInChildren<Stats>();

        int teamlevel = GameManager.GetTeamLevel();
        foreach (Stats enemy in enemies)
        {
            int newLevel = Random.Range(teamlevel - 3, teamlevel + 2);
            enemy.SetLevel(newLevel);
            switch (enemyAdvantage)
            {
                case 0:
                    Stats playerStats = playerTransform.GetComponent<Stats>();
                    playerStats.hp -= (int) (playerStats.hp * 0.05);
                    break;
                case 2:
                    enemy.hp -= (int) (enemy.hp * 0.2);
                    break;
            }

            Debug.Log(newLevel);
        }
        danoTotal = 0;
        tiempoDeCombate = 0;
    }

    public void EnemiesStart()
    {
        foreach (EnemyBattleManager enemy in GetComponentsInChildren<EnemyBattleManager>())
        {
            enemy.battleStarted = true;
        }
    }

    public void ResetPlayer()
    {
        playerTransform.position = playerOrigin;
        battling = false;
    }

    public string TiempoBatalla()
    {
        string minutos = Mathf.Floor(tiempoDeCombate / 60).ToString("00");
        string segundos = Mathf.Floor(tiempoDeCombate % 60).ToString("00");
        string milis = ((tiempoDeCombate - Math.Floor(tiempoDeCombate)) * 1000).ToString("00");
    
        return minutos + ":" + segundos + ";" + milis;
    }
}
