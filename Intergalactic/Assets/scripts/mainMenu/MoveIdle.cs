using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIdle : MonoBehaviour
{
    public float speed = 1f;
    public float amplitude = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Mathf.Sin(Time.time * speed) * amplitude;
        gameObject.transform.Translate(0, a, 0);
    }
}
