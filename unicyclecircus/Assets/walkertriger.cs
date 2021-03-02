using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkertriger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            for (int i = 0; i < 2; i++)
            {
                transform.GetChild(i).GetComponent<walker>().confirm = true ;

            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
