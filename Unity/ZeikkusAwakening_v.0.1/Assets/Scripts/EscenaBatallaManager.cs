using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EscenaBatallaManager : MonoBehaviour
{
    public GameObject[] spawners;

    public GameObject playerSpawn;
    [NonSerialized] public GameObject enemyToSpawn;
    [NonSerialized] public Vector3 playerOrigin;

    [NonSerialized] public Stats[] enemies;
    private bool alive;
    private Transform playerTransform;

    public int danoTotal;
    public float tiempoDeCombate;

    // Start is called before the first frame update
    void OnEnable()
    {
        playerTransform = FindObjectOfType<PlayerManager>().transform;
        playerOrigin = playerTransform.position;
        playerTransform.position = playerSpawn.transform.position;
        int randomLimit = 1;
        for (int i = 0; i < randomLimit; i++)
        {
            Instantiate(enemyToSpawn, spawners[i].transform);
        }
        enemies = GetComponentsInChildren<Stats>();
    }

    public void ResetPlayer()
    {
        playerTransform.position = playerOrigin;
    }

    public string TiempoBatalla()
    {
        //Añado el intervalo transcurrido a la variable tiempo
        tiempoDeCombate += Time.deltaTime;
    
        //Formateo minutos y segundos a dos dígitos
        string minutos = Mathf.Floor(tiempoDeCombate / 60).ToString("00");
        string segundos = Mathf.Floor(tiempoDeCombate % 60).ToString("00");
        string milis = ((tiempoDeCombate - Math.Floor(tiempoDeCombate)) * 1000).ToString("00");
    
        //Devuelvo el string formateado con : como separador
        return minutos + ":" + segundos + ";" + milis;
    }
}
