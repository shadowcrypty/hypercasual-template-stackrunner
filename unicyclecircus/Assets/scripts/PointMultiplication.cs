using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointMultiplication : MonoBehaviour
{
    public GameObject player;
    public int k = 1;
    public GameObject tekerlekler;
    // Start is called before the first frame update
    void Start()
    {

    }
    Transform lastchild()
    {
        return tekerlekler.transform.GetChild(tekerlekler.transform.childCount - 1);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<follow>())
        {
            for (int i = 0; i < k; k--)
            {
                
                Debug.Log(lastchild().name);
                tekerlekler.transform.GetChild(tekerlekler.transform.childCount - 1).gameObject.GetComponent<follow>().target = null;
                lastchild().tag = "Untagged";
                lastchild().SetParent(null);
                

                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 0.1f);
                player.GetComponent<LevelUp>().mutliplication = Int32.Parse(this.name);

            }

            

        }
        if (lastchild()==player.transform)
        {
            Debug.Log(this.name);
            player.transform.parent.GetComponent<playermovment>().speed = 0f;
            player.GetComponent<LevelUp>().mutliplication = Int32.Parse(this.name);
            //LevelUp
            player.GetComponent<LevelUp>().ui();

        }
    }
    }
