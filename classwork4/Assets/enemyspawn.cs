using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public Transform maxpos;
    public Transform midpos;
    public Transform minpos;
    public GameObject enemy;
    float speed = 10f;
    GameObject enemyclone;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn() 
    {
        speed += 0.5f;
        int randompos = Random.Range(1, 4);
        if (randompos == 1) 
        {
            enemyclone =  Instantiate(enemy, minpos);
        }
        else if (randompos == 2)
        {
            enemyclone = Instantiate(enemy, midpos);
        }
        else if (randompos == 3 )
        {
            enemyclone = Instantiate(enemy, maxpos);
        }
        enemyclone.GetComponent<enemymove>().speed = speed;
    }
}
