using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_SetRotation : MonoBehaviour
{
    public Transform targetT;
    void Start()
    {
        //transform.rotation = Quaternion.Euler(new Vector3(30, 30, 30));
        //Quaternion newRotation = Quaternion.Euler(new Vector3(45, 60, 90));        
        //transform.rotation = newRotation;

        //Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 1, 0));
        //transform.rotation = targetRotation;

        //Vector3 direction = targetT.position - transform.position;
        //Quaternion targetRotation1 = Quaternion.Euler(direction);
        //transform.rotation = targetRotation1;

        //Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        //Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));
        //Quaternion targetRotation2 = Quaternion.Lerp(aRotation, bRotation, 0.5f);
        //transform.rotation = targetRotation2;

        //Quaternion originRotation = transform.rotation;
        //Vector3 originRotInVector3 = originRotation.eulerAngles;
        //Vector3 targetRoaInVector3 = originRotInVector3 + new Vector3(30, 0, 0);
        //Quaternion targetRotation3 = Quaternion.Euler(targetRoaInVector3);
        //transform.rotation = targetRotation3;

        //Quaternion originalRot = Quaternion.Euler(new Vector3(45, 0, 0));
        //Quaternion plusRot = Quaternion.Euler(new Vector3(30, 0, 0));
        //Quaternion targetRot4 = originalRot * plusRot;
        //transform.rotation = targetRot4;        
    }

    void Update()
    {
        
    }
}
