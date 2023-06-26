using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float speed = 40.0f;
    Rigidbody ballRd;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        ballRd.AddForce(-speed, 0f, -speed*0.7f);

        startPos = new Vector3(0f, 0f, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = collision.transform.position;
            Vector3 incomVec = currPos - startPos;    // 입사각 계산
            Vector3 normalVec = collision.contacts[0].normal;  // 법선벡터
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);  // 반사각 계산 

//reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec * speed);

            startPos = collision.transform.position;
        }

        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Destroy(collision.gameObject);
        }
    }
}
