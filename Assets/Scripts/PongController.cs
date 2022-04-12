using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;

    public KeyCode upKey;
    public KeyCode downKey;
    private bool isMoving = false;
    private Vector2 directionToMove;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey)) {
            isMoving = true;
            directionToMove = Vector2.up;
        }
        if (Input.GetKey(downKey)) {
            isMoving = true;
            directionToMove = Vector2.down;
        }

        if (Input.GetKeyUp(downKey) || Input.GetKeyUp(upKey)) {
            isMoving = false;
            _rb.velocity = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        if (isMoving) {
            _rb.velocity = directionToMove * speed;
        }
    }
}
