using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    float currentPosition = -1f; // 현재 x 좌표(-1)
    float rightMax = 4f;
    float leftMax = -4f;
    int direction = 1;  // 또는 -1 (현재 Enemy 위치에서 오른쪽 또는 왼쪽 중 어느쪽으로 먼저 갈지에 대한 것일 뿐)

    void Start()
    {
        
    }



    void Update()
    {
        /*
        


        //현재 위치(x)가 우로 이동가능한 (x)최대값보다 크거나 같다면

        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 우로 이동가능한 (x)최대값으로 설정

        


        //현재 위치(x)가 좌로 이동가능한 (x)최대값보다 크거나 같다면

        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 좌로 이동가능한 (x)최대값으로 설정

        
        */

        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
        }

        else if (currentPosition <= leftMax)
        {
            direction *= -1;
            currentPosition = leftMax;
        }

        transform.position = new Vector3(currentPosition, 1f, -4f);  // transform.Translate(Vector3.left * speed * Time.deltaTime)
    }
    
}
