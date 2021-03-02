using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDestroyer : MonoBehaviour
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
                //this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                Debug.Log(lastchild().name);
                tekerlekler.transform.GetChild(tekerlekler.transform.childCount - 1).gameObject.GetComponent<follow>().target = null;
                lastchild().tag = "Untagged";
                lastchild().SetParent(null);
                //lastchild().position.Set(lastchild().position.x, 1f, lastchild().position.z);

                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 0.1f);
                //player.GetComponentInChildren<UnityStandardAssets.Utility.FollowTarget>().offset.z += 1f;
                Handheld.Vibrate();
            }

            //Destroy(other.gameObject);

        }

    }
}
