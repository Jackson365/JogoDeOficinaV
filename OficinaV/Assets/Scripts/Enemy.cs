using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float walkTime;

    private bool walkRight = true;

    public int health;
    public int damage = 1;
    
    private float timer;
    private Rigidbody2D rig;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= walkTime)
        {
            walkRight = !walkRight;
            timer = 0f;
        }

        if (walkRight)
        {
            transform.eulerAngles = new Vector2(0, 0);
            rig.velocity = Vector2.right * speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 180);
            rig.velocity = Vector2.left * speed;
        }
        
    }

    public void Damage(int vida)
    {
        health -= vida;
        anim.SetTrigger("hit");

        if(health <= 0)
            {
                Destroy(gameObject);
            }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().Damage(damage);
        }
    }
}
