using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{

    public Color selectedColour;
    public Color unselectedColour;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }

    public void Selected(bool isSelected)
    {
        if(isSelected == true)
        {
            spriteRenderer.color = selectedColour; ;
        }
        else
        {
            spriteRenderer.color = unselectedColour;
        }


    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

}
