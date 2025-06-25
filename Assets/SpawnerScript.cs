using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spwnRate = 2;
    private float timer = 0;
    public float heghtOffset = 10;
    public BirdScript birdScript;

    // Start is called before the first frame update
    void Start()
    {
        spwnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwnPipe();
            timer = 0;
        }
    }

    void spwnPipe()
    {
        float min = transform.position.y - heghtOffset;
        float max = transform.position.y + heghtOffset;
        Instantiate(Pipe, new Vector3(transform.position.x,  Random.Range(min,max), 0), transform.rotation);
    }

    public void stopGame()
    {
        spwnRate = 0;
    }
}
