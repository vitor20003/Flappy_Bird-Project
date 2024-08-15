using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Destroy(this.gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        mov_obj();
    }

    void mov_obj()
    {
       
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        
    }
}
