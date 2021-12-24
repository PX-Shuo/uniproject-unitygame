using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialStageClearManager : MonoBehaviour
{
    Animator anim;
//    GameObject enemy;
//    EnemyAttack enemyAttack;
//    EnemyMovement enemyMovement;

//    GameObject enemies;
    GameObject minimap;

    void Awake()
    {
        anim = GetComponent<Animator>();
//        enemy = GameObject.FindGameObjectWithTag("Enemy");
//        enemyAttack = enemy.GetComponent<EnemyAttack>();
//        enemyMovement = enemy.GetComponent<EnemyMovement>();

//        enemies = GameObject.FindGameObjectWithTag("Enemies");
        minimap = GameObject.FindGameObjectWithTag("Minimap");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Achieved.score == 2)
        {
            Destroy(minimap.gameObject);
            anim.SetTrigger("StageClear");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(2);
            }
        }
    }

/*    IEnumerator Wait()
    {
        print(Time.time);
        yeild return new WaitForSeconds(5);
        print(Time.time);
    }
    */
}
