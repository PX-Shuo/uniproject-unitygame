using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achieved : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update

    void Awake()
    {
        score = 0;
    }

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider Other)
    {
        if(Other.tag == "ball")
        {
            score ++;
            Destroy(Other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
