using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public Text basictext;
    public Text Btext;
    public Transform Tui;
    public int mutliplication;
    
    void Start()
    {
        
    }
    public void ui()
    {
        basictext.text = "Level Complete";
        Btext.text = "Next Level";
        Tui.gameObject.SetActive(true);
    }

    
    void Update()
    {
        if(mutliplication == 5)
        {
            this.transform.parent.GetComponent<playermovment>().speed = 0f;
            //LevelUp
        }
       
        
    }
}
