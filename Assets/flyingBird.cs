using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource wingEffect;
    [SerializeField] private AudioSource deathEffect;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameManager.check == true)
        {
            if(Input.GetMouseButton(0))
            {
                jump();
            }

            if(Input.GetKeyDown("space"))
            {
                jump();
            }
        }
    }

    public void jump()
    {
        rb.velocity = Vector2.up * velocity;
        wingEffect.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        deathEffect.Play();
        gameManager.GameOver();
    }
}
