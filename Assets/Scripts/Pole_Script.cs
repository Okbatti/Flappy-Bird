using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_Script : MonoBehaviour
{

    [SerializeField]
    float speed;

    void Start()
    {
        
    }

    void Update()
    {

        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;


    }
}
