using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public SpeedSettings speedsettings;
    //public float speed ;
    // Start is called before the first frame update
    void Start()
    {
        //speed = speedsettings.Speed;
        
    }

    // Update is called once per frame
    void FixedUpdate()

    {
        transform.Translate(Vector3.forward * speedsettings.Speed);
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //Debug.Log(touchDeltaPosition);
            touchDeltaPosition = new Vector2(touchDeltaPosition.x,0);
            
            if (transform.position.x<3f && transform.position.x >-3f)
            {
                transform.Translate(new Vector3(touchDeltaPosition.x * 0.05f, 0, 0));
            }
            else if (transform.position.x > 3f)
            {
                transform.Translate(new Vector3(-0.05f, 0, 0));
            }
            else if (transform.position.x <-3f)
            {
                transform.Translate(new Vector3(+0.05f, 0, 0));
            }





        }
        
        
        
    }
}
