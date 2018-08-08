using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

    int speed = 1;

    public void Start()
    {
        speed = Random.Range(1, 6);
    }
  
    void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (this.transform.position.x > 16.0f || this.transform.position.x < -16.0f)
        Destroy(gameObject);
    }
}