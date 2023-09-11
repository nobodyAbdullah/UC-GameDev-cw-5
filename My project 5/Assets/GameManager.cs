using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Maxpos;
    public Transform midpos;
    public Transform Minpos;
    public GameObject Enemy;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f,delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
       int RandomPos = Random.Range(1,4);
       if ( RandomPos == 1 )
       {
        Instantiate(Enemy,midpos);
       }
       else if ( RandomPos == 2 )
       {
        Instantiate(Enemy,Maxpos);
       }
       else if ( RandomPos == 3 )
       {
        Instantiate(Enemy,Minpos);
       }
    }
}
