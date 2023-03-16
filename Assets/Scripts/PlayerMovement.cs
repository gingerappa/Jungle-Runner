using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float MovementSpeed = 1;
    public int hp = 1;

    private float facingDirX = 1;

    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");

        transform.Translate(transform.right * dirX * speed * Time.deltaTime);

        if (dirX == -1 || dirX == 1)
        {
            facingDirX = dirX;
        }
    }
}
