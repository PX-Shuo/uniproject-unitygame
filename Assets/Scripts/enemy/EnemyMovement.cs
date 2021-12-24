using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // GameObject myPlayer;
    Transform player;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        nav = GetComponent<NavMeshAgent>();
        // Debug.Log(GameObject.FindGameObjectsWithTag("Player").Length);
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
