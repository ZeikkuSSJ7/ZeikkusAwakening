using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ZagrantController : MonoBehaviour
{

    private Animator animator;
    private GameManager gameManager;
    private AudioSource source;
    public bool isAttacking;

    // Start is called before the first frame update
    void Start()
    {
        animator = FindObjectOfType<AnimatorManager>().animator;
        gameManager = FindObjectOfType<GameManager>();
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!gameManager.inWorld)
            isAttacking = animator.GetBool("isAttacking");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isAttacking)
        {
            if (other.gameObject.CompareTag("Enemigo"))
            {
                EnemyBattleManager enemyBattleManager = other.gameObject.GetComponent<EnemyBattleManager>();
                Stats zeikkuStats = FindObjectOfType<PlayerLocomotion>().gameObject.GetComponent<Stats>();
                enemyBattleManager.RecieveDamage(zeikkuStats, animator.GetFloat("damage"), true);
                source.PlayOneShot(source.clip);
                Debug.Log(Environment.StackTrace);
            }
            else
            {
                isAttacking = false;
            }
        }
        else
        {
            if (other.gameObject.CompareTag("EnemigoWorld"))
            {
                FindObjectOfType<GameManager>().ToBattle(other.gameObject.GetComponent<EnemyManager>().enemyToSpawn);
                Destroy(other.gameObject);
            }
        }
    }
}
