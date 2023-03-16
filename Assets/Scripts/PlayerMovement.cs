using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float speed = 16f;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        // Create velocity, get input and set movement
        Vector2 velocity = body.velocity;
        velocity.x = Input.GetAxis("Horizontal") * speed;
        body.velocity = velocity;
    }
}
