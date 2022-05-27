using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        /*if (col.gameObject.name == "DeathWall")
        {
            Destroy(gameObject);
        }*/
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(-3.35f,0.5f,-3.61f);
            transform.eulerAngles = new Vector3(0,90,0);
        }
        if (col.gameObject.name == "DeathPlane")
        {
            transform.position = new Vector3(-3.35f,0.5f,-3.61f);
            transform.eulerAngles = new Vector3(0,90,0);
        }
    }
}
