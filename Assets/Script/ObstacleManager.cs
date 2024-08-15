using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obstaculo_;
    public float velocidade_spawn;
    float cooldown_ = 0  ;
     ScoreManager scoreManager;
    //public GameObject obstaculo_spawn;
    
    void Start()
    {
        cooldown_ = 1;
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    
    void Update()
    {
        time_spawn();
       
       
    }

    public void time_spawn()
    {
        if(cooldown_ > 0)
        {
            cooldown_ -= Time.deltaTime;
            
        }
        else
        {
            
            cooldown_ = 3.5f-(scoreManager.score_/10);
            Spawn_obstacle();




        }
      
    }

    void Spawn_obstacle()
    {
        Instantiate(obstaculo_,new Vector3(5, Random.RandomRange(-3,3),0), Quaternion.identity);
    }
}
