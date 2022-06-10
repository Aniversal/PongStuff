using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float pSpeed;
    public Rigidbody2D rb2;
    public Vector3 startPosition;

    private float movement;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb2.velocity = new Vector2(rb2.velocity.x, movement * pSpeed);
    }

    public void Reset()
    {
        rb2.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
