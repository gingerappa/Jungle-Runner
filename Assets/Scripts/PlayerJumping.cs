using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    public float Jumpforce = 5;

    public float jumpTime = 0.35f;
    public float jumpTimeCounter;
    private bool isJumping;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody.velocity.y) < 0.001)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            _rigidbody.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                _rigidbody.velocity = Vector2.up * Jumpforce;
                jumpTimeCounter -= Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }


}
