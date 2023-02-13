using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_ScoreSubtrator : MonoBehaviour
{    
    void Start()
    {
        
    }
        
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _0209_ScoreManager.GetInstance().AddScore(-2);
            Debug.Log(_0209_ScoreManager.GetInstance().GetScore());
        }
    }
}
