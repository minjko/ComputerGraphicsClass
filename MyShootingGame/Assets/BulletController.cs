using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            // GetComponent<Rigidbody>().AddForce(0, 0, -20);
            Shoot(new Vector3(0, 0, -20));
        }
        */
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ENEMY"))
        {
            // Destroy(collision.gameObject);  // 에너미 없앰
            Destroy(gameObject); // 총알 없앰

            GameObject s_manager = GameObject.Find("ScoreManager");
            s_manager.GetComponent<ScoreManager>().IncScore();
            
        }
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
