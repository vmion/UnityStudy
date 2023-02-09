using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_ScoreAdder : MonoBehaviour
{   
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _0209_ScoreManager.GetInstance().AddScore(5);
            Debug.Log(_0209_ScoreManager.GetInstance().GetScore());
        }
    }
}
