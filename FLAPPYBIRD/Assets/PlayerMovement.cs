using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public int skor;
    public Text scoreText;
    private bool isDead;
    public GameObject deadPanel;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, Time.fixedDeltaTime * speed);
        }
        if (isDead)
        {
            Time.timeScale = 0;
            deadPanel.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "skor")
        {
            skor++;
            scoreText.text= skor.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}
