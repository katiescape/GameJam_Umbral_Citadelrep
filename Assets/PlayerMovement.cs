using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10f;
    private Vector2 lastClickedPos;
    private bool moving;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != lastClickedPos) {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        } else if ((Vector2)transform.position == lastClickedPos) {
            moving = false;
        }
    }
}