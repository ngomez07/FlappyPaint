using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float deathZone = -13.5f;
    public GameObject pipe;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < deathZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(pipe);
        }
    }
}
