using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public Transform Minpos;
    public Transform Maxpos;
    public float inc = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
     void move()
     {
        if (Input.GetKeyDown(KeyCode.D))
        {
          transform.position = new Vector3 (Mathf.Clamp( transform.position.x + inc, Minpos.position.x , Maxpos.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
          transform.position = new Vector3 (Mathf.Clamp( transform.position.x - inc, Minpos.position.x , Maxpos.position.x), transform.position.y, transform.position.z);
        }
     }
     private void OnCollisionEnter(Collision Collision)
    {
        if(Collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
    }
}
