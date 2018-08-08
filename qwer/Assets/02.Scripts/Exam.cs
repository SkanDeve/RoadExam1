using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Vector3.left * 50 * Time.deltaTime);  // 50의 속도로 기차 이동 
    }

}