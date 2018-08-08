using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMaker : MonoBehaviour {

    public Transform prefab;

    int j = 2; //z값

    void Start () 
    {
        InvokeRepeating("EX", 1, 2);        // EX를 1초후에 2초에 한번씩 실행
   	}

    void EX()
    {
        int num = Random.Range(0, 2);      // 0 또는 1

        switch (num)
        {
            case 0:
                
                Instantiate(prefab, new Vector3(-11, 0, j),Quaternion.Euler(0,-180,0));       // 왼쪽에 방향회전해서 생성
                                j += 2;
                break;

            case 1:
                Instantiate(prefab, new Vector3(9, 0, j), Quaternion.identity); j += 2;     // 오른쪽에 생성
                break;

        }
        

    }
	 
	
}
