using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PlanePrefab;
    Vector3 Pos;
    Quaternion Rot;
    float loadingTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Spawn = Instantiate(PlanePrefab, Pos, Rot);
    }

    // Update is called once per frame
    void Update()
    {
        loadingTimer = loadingTimer + Time.deltaTime;
        if(loadingTimer > 0 && loadingTimer < 6) {

            transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0);
            transform.rotation = Quaternion.identity(0,0,Random.Range(-5, 5));
        }
           
    }
}
