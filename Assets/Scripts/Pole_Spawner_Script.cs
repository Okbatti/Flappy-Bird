 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_Spawner_Script : MonoBehaviour
{

    public float MaxTime = 1;
    public float timer = 0;
    public GameObject pole;
    public float height;

    void Start()
    {
        GameObject newPole = Instantiate(pole);
        newPole.transform.position = transform.position + new Vector3(0, Random.RandomRange(-height, height), 0);
    }

    void Update()
    {
        if (timer > MaxTime)
        {
            GameObject newPole = Instantiate(pole);
            newPole.transform.position = transform.position + new Vector3(0, Random.RandomRange(-height, height), 0);
            Destroy(newPole, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
