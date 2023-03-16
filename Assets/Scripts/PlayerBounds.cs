using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour {
    private float minX, maxX;

    // Start is called before the first frame update
    void Start() {
        // Get screen width and height
        Vector2 coordinates = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        minX = -coordinates.x + 1.02f;
        maxX = coordinates.x - 1.02f;
    }

    // Update is called once per frame
    void Update() {
        Vector2 tempPos = transform.position;

        if (tempPos.x < minX) {
            tempPos.x = minX;
        }

        if (tempPos.x > maxX) {
            tempPos.x = maxX;
        }

        transform.position = tempPos;
    }
}
