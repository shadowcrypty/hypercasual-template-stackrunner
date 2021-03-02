using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelcontrol : MonoBehaviour
{
    public GameObject tekerler;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && this.tag == "wheel")
        {
            Debug.Log("teker");
            GetComponent<follow>().target= tekerler.transform.GetChild(tekerler.transform.childCount - 1);
            transform.SetParent(tekerler.transform);
            //other.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f, this.gameObject.transform.position.z);
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1f, player.transform.position.z);
            gameObject.transform.tag = "Player";
            Handheld.Vibrate();
            //player.GetComponentInChildren<UnityStandardAssets.Utility.FollowTarget>().offset.z -= 2;



        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
