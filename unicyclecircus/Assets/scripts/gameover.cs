using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject ui;
    public Text text;
    public Text bText;
    public Button button;
   
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BasicDestroyer>().k!=0)
        {
           
            
            transform.parent.GetComponent<playermovment>().speed = 0f;
            text.text = "Game Over";
            bText.text = "Try Again";
            ui.SetActive(true);
            button.onClick.AddListener(resetscene);
            

        }
    }
    public void resetscene()
    {
        SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
