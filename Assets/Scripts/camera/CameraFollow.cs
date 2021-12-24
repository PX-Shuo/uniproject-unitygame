using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;            // The position that that camera will be following.
    public float smoothing = 5f;        // The speed with which the camera will be following.
    public GameObject player;

    Vector3 offset;
    Vector3 targetCamPos;

    void start()
    {
        offset = transform.position - target.position;
        Debug.Log(offset);
    }

    void Update()
    {
        /*if (player.GetComponent<PlayerMovement>().returnMoving())
        {
            // Vector3 targetCamPos = target.position + offset;
            Vector3 targetCamPos = new Vector3(target.position.x + offset.x, transform.position.y, target.position.z + offset.z);
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
            // transform.position = Vector3.MoveTowards(transform.position, targetCamPos, smoothing * Time.deltaTime);
        }*/

        targetCamPos = new Vector3(target.position.x + offset.x, transform.position.y, target.position.z + offset.z);
        transform.position = targetCamPos;

    }
}
