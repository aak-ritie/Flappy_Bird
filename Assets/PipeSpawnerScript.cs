using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipePrefab;
    public float spawnRate = 3;
    private float timer= 0;
    public float heightOffset = 15;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
       
    }
    void SpawnPipe()
    {
        float lowestPoint=transform.position.y-heightOffset;
        float highestPoint=transform.position.y+heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
