using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    Text txt;
    private int pHealth;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Health : " + pHealth;
    }

    // Update is called once per frame
    void Update()
    {
        pHealth = GameObject.Find("Player").GetComponent<PlayerHealth>().playerHealth;

        if(pHealth > 0)
        {
            txt.text = "Health : " + pHealth;
        }
        else if(pHealth <= 0)
        {
            txt.text = "Game Over";
        }
        
    }
}
