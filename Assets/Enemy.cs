using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemyTransform;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newMovement = new Vector3(0, -1, 0);
        newMovement *= speed;
        newMovement *= Time.deltaTime;
        enemyTransform.position += newMovement;
        
    }
}
