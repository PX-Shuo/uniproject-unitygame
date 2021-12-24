using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightMov : MonoBehaviour
{
    Vector3 endPos;
    Vector3 startPos;
    GameObject lighty;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(-30f, 19f, 33f);
        lighty = GameObject.FindGameObjectWithTag("myLight");
        lighty.transform.position = startPos;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
