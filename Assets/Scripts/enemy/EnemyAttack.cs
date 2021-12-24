using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackInterval = 0.6f;
    public int attackDamage = 12;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider Other)
    {
        if(Other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= attackInterval && playerInRange)
        {
            Attack();
        }
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("PlayerDead");
        }
    }

    void Attack()
    {
        timer = 0f;
        if (playerHealth.currentHealth >= 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
