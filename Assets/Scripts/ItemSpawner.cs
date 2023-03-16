using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject fish;
    public GameObject bomb;
    private BoxCollider2D collider;
    float x1, x2;

    // Start is called before the first frame update
    void Start() {
        collider = GetComponent<BoxCollider2D>();

        x1 = transform.position.x - collider.bounds.size.x / 2f;
        x2 = transform.position.x + collider.bounds.size.x / 2f;

        StartCoroutine(SpawnFish(1f));
    }

    IEnumerator SpawnFish(float time) {
        yield return new WaitForSecondsRealtime(time);

        Vector2 tempPos = transform.position;
        tempPos.x = Random.Range(x1, x2);
        tempPos.y = tempPos.y - 1f;

        int rngItem = Random.Range(1, 6);

        if (rngItem > 2)
        {
            Instantiate(fish, tempPos, Quaternion.identity);
        }
        else {
            Instantiate(bomb, tempPos, Quaternion.identity);
        }
        
        StartCoroutine(SpawnFish(Random.Range(0.5f, 2f)));
    }
}
