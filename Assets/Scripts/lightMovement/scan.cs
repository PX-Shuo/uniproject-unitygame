using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scan : MonoBehaviour
{
    //21， -77， -211.11
    //      -4
    GameObject lighty;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        lighty = GameObject.FindGameObjectWithTag("myLight");
        offset = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        lighty.transform.localEulerAngles = new Vector3(lighty.transform.rotation.x, lighty.transform.rotation.y + offset.y, lighty.transform.rotation.z);
    }
}
