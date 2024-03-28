using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator _animator;
    Vector3 theScale = new Vector3(4f, 4f, 4f);

    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputX = Input.GetAxisRaw("Horizontal");
        var jumpInput = Input.GetButton("Jump");

        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);

        _animator.SetBool("isWalking", inputX != 0);

        if(inputX > 0)
        {
            theScale.x = 4;
            rb.transform.localScale = theScale;
        }

        else if(inputX < 0)
        {
            theScale.x = -4;
            rb.transform.localScale = theScale;
        }

    }
}
