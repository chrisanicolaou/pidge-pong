using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;

    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;
    public GameObject newBall;

    private Vector2 direction;
    public GameObject enemyPaddle;
    private int randomDirection;
    private bool setupComplete = false;
    private EnemyPongController focusEnemyPaddle;
    void Start()
    {
        StartCoroutine("SetupBall");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (setupComplete) {
        _rb.velocity = speed * direction;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        var collidedWith = col.gameObject.tag;
        if (collidedWith == "LeftPong") {
            var yDirection = this.transform.position.y - col.gameObject.transform.position.y;
            direction = new Vector2(1, yDirection / 1.8f);
        }
        if (collidedWith == "RightPong") {
            var yDirection = this.transform.position.y - col.gameObject.transform.position.y;
            direction = new Vector2(-1, yDirection / 1.8f);
        }
        if (collidedWith == "Edge") {
            direction = new Vector2(direction.x, direction.y * -1);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        var collidedWith = col.gameObject.tag;
        if (collidedWith == "RightEdge") {
            Globals.playerOneScore++;
            playerOneScoreText.text = Globals.playerOneScore.ToString();
            StartCoroutine("SpawnNewBall");
        }
        if (collidedWith == "LeftEdge") {
            Globals.playerTwoScore++;
            playerTwoScoreText.text = Globals.playerTwoScore.ToString();
            StartCoroutine("SpawnNewBall");
        }
    }

    IEnumerator SpawnNewBall()
    {
        Globals.CheckWinner();
        if (Globals.winner != "") {
            SceneManager.LoadScene("End_Scene");
            yield break;
        }
        yield return new WaitForSeconds(1f);
        Instantiate(newBall, Vector3.zero, Quaternion.identity);
        if (!Globals.isMultiplayer) {
        focusEnemyPaddle.ball = newBall.GetComponent<Transform>();
        }
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }

    IEnumerator SetupBall()
    {
        yield return new WaitForSeconds(0.3f);
        randomDirection = Random.Range(0, 2);
        _rb = GetComponent<Rigidbody2D>();
        if (!Globals.isMultiplayer) {
            Debug.Log("Doing things");
            focusEnemyPaddle = enemyPaddle.GetComponent<EnemyPongController>();
            focusEnemyPaddle.ball = this.transform;
        }
        if (randomDirection == 0) {
            direction = Vector2.right;
        }
        if (randomDirection == 1) {
            direction = Vector2.left;
        }
        setupComplete = true;
    }
}
