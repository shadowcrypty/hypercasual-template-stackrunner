using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncer : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="wall")
        {
            speed *= -1;

        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed,0,0,null);
    }
}
