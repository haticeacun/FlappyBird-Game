using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float timer;
    private float baseTimer;
    void Start()
    {
        baseTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject go=Instantiate(pipe, transform);
            go.transform.position = new Vector2(go.transform.position.x, Random.Range(-0.75f, 1.60f));
            timer = baseTimer;
        }
        
    }
}
