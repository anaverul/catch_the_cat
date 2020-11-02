
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cats;
    public float xBounds, yBound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        if (ScoreController.score >=1 && ScoreController.score <= 19)
        {
            yield return new WaitForSeconds(Random.Range(3, 4));
            int randomCat = Random.Range(0, cats.Length);
            if (Random.value <= 0.5f)
                Instantiate(cats[randomCat], new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
            StartCoroutine(SpawnRandomGameObject());
        }
    }

}
