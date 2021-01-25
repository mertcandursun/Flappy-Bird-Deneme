using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBird : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public bool isDead;

    public GameManager managergame;

    public GameObject OlumEkrani;

    // Start is called before the first frame update
    void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "puan")
            {
                Destroy(gameObject);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "puan")
        {
            managergame.UpdateScore();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            OlumEkrani.SetActive(true);
        }
    }

    
}


