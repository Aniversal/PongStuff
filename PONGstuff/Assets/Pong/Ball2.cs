using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    public float speeds;
    public Rigidbody2D rb2;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb2.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb2.velocity = new Vector2(speeds * x, speeds * y);
    }
}
