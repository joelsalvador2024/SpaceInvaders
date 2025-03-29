using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    float horizontal;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

    }

    void FixedUpdate()
    {
        if (horizontal > 0)
        {
            rb.velocity = new Vector3(speed * 1, 0, 0);
        }
        if (horizontal < 0)
        {
            rb.velocity = new Vector3(speed * -1, 0, 0);
        }
        if (horizontal == 0)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    void Shoot()
    {

    }
}
