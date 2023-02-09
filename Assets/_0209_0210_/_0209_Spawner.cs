using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_Spawner : MonoBehaviour
{
    public Transform spawnPosition;
    //public GameObject target;
    public Rigidbody target;
    void Start()
    {
        //GameObject instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
        Rigidbody instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
        //instance.GetComponent<Rigidbody>();

        instance.AddForce(0, 1000, 0);
        Debug.Log(instance.name);
    }

    void Update()
    {
        
    }
}
