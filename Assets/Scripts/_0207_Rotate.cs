using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0207_Rotate : MonoBehaviour
{
    Transform myTransform;
    void Start()
    {
        myTransform = GetComponent<Transform>();
        
    }

    void Update()
    {
        transform.Rotate(1, 1, 1);
    }
}
