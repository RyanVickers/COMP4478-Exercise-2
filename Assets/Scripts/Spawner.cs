using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bomb;
    public GameObject[] objects;

    public float xBounds, yBounds;

    void Start(){
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomObject = Random.Range(0, objects.Length);

        if (Random.value <= .6f)
            Instantiate(objects[randomObject],
            new Vector2(Random.Range(-xBounds, xBounds),yBounds), Quaternion.identity);
            else
                Instantiate(bomb,
            new Vector2(Random.Range(-xBounds, xBounds),yBounds), Quaternion.identity);
            
            StartCoroutine(SpawnRandomGameObject());
    
    }

}
