using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 3;
    public GameObject knight;
    float timer = 0;
    public float maxTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rb.MovePosition(rb.position - direction);
    }


    void Update()
    {
        timer += Time.deltaTime;
        if(timer>maxTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        knight.SendMessage("TakeDamage", 1);
        Destroy(gameObject);
    }



    // Update is called once per frame
    
}
