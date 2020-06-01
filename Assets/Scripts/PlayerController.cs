using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool perspective;
    private Animator myAnim;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        perspective = true;
    }
    void Update()
    { 
        float horizontal = Input.GetAxis("Horizontal");   // yatay gidis axisini aldım
        Movement(horizontal);
        TurnBack(horizontal);

    }

    public void Movement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);  
        myAnim.SetFloat("speed", Mathf.Abs(horizontal));

    }

    private void TurnBack(float horizontal)
    {
        if (horizontal > 0 && !perspective || horizontal < 0 && perspective)
        {
            perspective = !perspective;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;

        }
    }


}
