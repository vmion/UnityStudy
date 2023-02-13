using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0208_Itembox : MonoBehaviour
{
    public bool isOveraped;
    Renderer myRenderer;
    public Color touchColor;
    Color originalColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;            
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;            
        }
    }
    void Update()
    {
        
    }
}
