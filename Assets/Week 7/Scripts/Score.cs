using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshProUGUI scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = "score" + Controller.score;
    }
}
