using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float JumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * JumpPower;// (0, 3)
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //Collision끼리 부딪혔을때 Scene 이동
    {
        if (Score.score > Score.bestscore) //score가 bestscore보다 클 경우 bestscore에 반영
        {
            Score.bestscore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
