using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Controller.score ++;
    }

}
