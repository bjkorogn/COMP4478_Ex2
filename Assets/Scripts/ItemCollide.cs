using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollide: MonoBehaviour {
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Net") {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Ground") {
            Destroy(this.gameObject);
        }
    }
}
