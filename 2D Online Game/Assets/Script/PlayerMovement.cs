using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float x;

    public float moveSpeed;
    public float jumpForce;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");

        transform.position +=(Vector3) new Vector2(x * moveSpeed * Time.deltaTime, 0);

        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
