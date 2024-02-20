using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SlimeMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Mover;
    Vector2 endPos;
    public float speed = 2;
    Animator animator;
    public GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        endPos = transform.position;
    }

     
    private void FixedUpdate()
    {
        Mover = endPos - (Vector2)transform.position;
        if (Mover.magnitude < 0.1)
        {
            Mover = Vector2.zero;
        }

        rb.MovePosition(rb.position + Mover.normalized * speed * Time.deltaTime);

        animator.SetFloat("Movement", Mover.magnitude);
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SendMessage("Death");
        player.SendMessage("Death2");

        animator.SetTrigger("Attack");

    }


}
