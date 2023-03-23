using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public int hp = 2;
    public float startingDir = 1f;

    Animator anim;
    float dirX = 1f;
    bool isAlive = true;

    private void Start()
    {
        dirX = startingDir;
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (isAlive)
        {
            transform.Translate(transform.right * dirX * speed * Time.deltaTime);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right * dirX, 0.6f);

            if (hit.collider != null && hit.collider.CompareTag("MapTiles"))
            {
                dirX *= -1f;
            }
        }
    }

    public void TakeDamage()
    {
        hp--;

        if (hp <= 0)
        {
            Die();
        }
    }

    public void TakeHeavyDamage()
    {
            Die();
    }

    void Die()
    {
        isAlive = false;
        anim.SetBool("isAlive", false);
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, 1.5f);
    }
}
