using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMeddle : MonoBehaviour
{
    public LogicScript logic;
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logec").GetComponent<LogicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.aadScore(1);
            music.Play();
        }
    }

}
