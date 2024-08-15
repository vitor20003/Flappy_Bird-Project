using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float pulo;
    public GameObject game_over;

    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        impulso();
    }

    void impulso()
    {
        if (Input.GetKeyDown(KeyCode.Space)){

            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode2D.Impulse);
            
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Wall")
        {

            this.enabled = false;
            game_over.SetActive(true);


        }
    }

}
