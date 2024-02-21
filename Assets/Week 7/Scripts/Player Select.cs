using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{

    public Color selectedColour;
    public Color unselectedColour;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Selected(true);
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

}
