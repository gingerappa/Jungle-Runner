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
        TakeDamage();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckPointReached();
    }

    void TakeDamage()
    {
        Debug.Log("Ouch");
    }

    void CheckPointReached() { 
    
    }
}
