using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBodt;
    public float jumpStringth;
    public LogicScript logic;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logec").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive && Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigidBodt.velocity = Vector2.up * jumpStringth;

            if (transform.position.y > 19.76 || transform.position.y < -19.76)
            {
                logic.gameOver();
                birdIsAlive = false;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}
