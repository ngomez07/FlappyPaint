using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 1;
    public float timer = 0;
    public float heightOffset = 20;
    public float cloudChange;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        cloudChange = Random.Range(0.5f,-0.75f);
        cloud.transform.localScale += new Vector3 (cloudChange,cloudChange,0);
        if(cloud.transform.localScale.y < 0 || cloud.transform.localScale.x > 1.5f)
        {
            cloud.transform.localScale = new Vector3 (1, 1, 1);
        }
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
    private void Start()
    {
        spawnCloud();
    }
}
