using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour
{
    public float speed;
    public bool confirm=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (confirm)
        {
            transform.Translate(Vector3.back * speed);
        }
    }
}
