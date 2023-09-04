using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermove : MonoBehaviour
{
    public Transform maxpos;
    public Transform minpos;
    public float inc = 3f;
    AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move() 
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos.position.x, maxpos.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos.position.x, maxpos.position.x), transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy") 
        {
            audio();
            Invoke("restart", 1f);
        }
    }
    private void restart() 
    {
       SceneManager.LoadScene(0);
    }
    private void audio() 
    {
        src.Play();
    }
}
