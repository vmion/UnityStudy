using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_Move : MonoBehaviour
{
    public Vector3 move = new Vector3(-5, -5, -5);
    void Start()
    {        
    }
    void Move()
    {
        transform.Translate(move * Time.deltaTime, Space.World);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Move();
        }
    }
}
