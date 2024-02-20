using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Mover;
    Vector2 endPos;
    public float speed = 5;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }




}
