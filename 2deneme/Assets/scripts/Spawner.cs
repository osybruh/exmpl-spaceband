using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Player s;

    public GameObject[] prefabs;
    
    private int randomNumber;
    
    public float width;

    public float time;


    void Start()
    {
        StartCoroutine(SpawnAsteroid(time));    
    }

    public IEnumerator SpawnAsteroid(float time)
    {
        while (!s.isDead)
        {
            randomNumber = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomNumber], new Vector3(Random.Range(-width,width), 2, 0), Quaternion.identity);
            time -= 5f * Time.deltaTime;
            yield return new WaitForSeconds(time);            
        }
    }
}
