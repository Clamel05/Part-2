using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Mover;
    Vector2 endPos;
    public float speed = 5;
    Animator animator;
    public GameObject NextSceneZone;
    public GameObject NextSceneText;

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

        animator.SetFloat ("Speed", Mover.magnitude);


    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


    }


    public void Death()
    {
        animator.SetTrigger("Death");//Sets the initial death animation

        Destroy(NextSceneZone.gameObject);
        Destroy(NextSceneText.gameObject);
    }

    public void Death2()
    {
            animator.SetTrigger("Death2");//Sets the animation to keep the player lying on the ground
    }




}
