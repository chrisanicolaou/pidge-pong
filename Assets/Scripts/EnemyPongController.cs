using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPongController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;

    public Transform ball;
    private Vector2 directionToMove;

    private BallController accessBall;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        accessBall = GameObject.Find("Ball").GetComponent<BallController>();
        accessBall.enemyPaddle = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (ball.position.y - 1> this.transform.position.y) {
            _rb.velocity = Vector2.up * speed;
        }
        if (ball.position.y + 1< this.transform.position.y) {
            _rb.velocity = Vector2.down * speed;
        }
    }
}
