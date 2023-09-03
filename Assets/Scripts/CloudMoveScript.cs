using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float deathZone = -15.5f;
    public GameObject cloud;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < deathZone)
        {
            Debug.Log("Cloud Deleted");
            Destroy(cloud);
        }
    }
}