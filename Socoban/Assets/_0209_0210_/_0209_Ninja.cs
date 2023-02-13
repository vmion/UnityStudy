using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_Ninja : MonoBehaviour
{
    public static _0209_Ninja NinjaKing;
    public string ninjaName;
    public bool isKing;
    private void Start()
    {
        if(isKing)
        {
            NinjaKing = this;
        }
    }
    private void Update()
    {
        Debug.Log("My name: " + ninjaName + ", NinjaKing is " + NinjaKing);
    }
}
