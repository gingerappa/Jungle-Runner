using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageScript : MonoBehaviour
{
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Jump;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if(Input.GetKey(Right))
         {
            transform.Translate(transform.right * 1 * speed * Time.deltaTime);
         }

        if (Input.GetKey(Left))
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(Jump))
        {
            transform.Translate(transform.up * 1 * speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            CheckPointReached();
        }

        
        if (collision.gameObject.CompareTag("healthboost"))
        {
            HealthBoost();
        }

        if (collision.gameObject.CompareTag("DamageBoost"))
        {
            DamageBoost();
        }

        if (collision.gameObject.CompareTag("SpeedBoost"))
        {
            SpeedBoost();
        }

    }

    void TakeDamage()
    {
        Debug.Log("Ouch");
    }

    void CheckPointReached() {
        Debug.Log("checkpoint reached!");
    }

    void HealthBoost()
    {
        //hp++ 
        Debug.Log("I feel a bit better now");
    }

    void SpeedBoost()
    {
        //speed++ for 10 sec
        Debug.Log("I am S P E E D");
    }

    void DamageBoost()
    {
        //damage ++ for 10 sec
        Debug.Log("strongk");
    }
}
