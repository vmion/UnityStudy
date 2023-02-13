using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_Dog : MonoBehaviour
{
    public string nickName;
    public float weight;
    public static int count = 0;
    void Awake()
    {
        count = count + 1;
    }
    void Start()
    {
        Bark();        
    }
    public void Bark()
    {
        Debug.Log("모든 개들의 수 : " + count);
        Debug.Log(nickName + ": Bark!");
    }
    public static void ShowAnimalType()
    {
        Debug.Log("이것은 개입니다.");
    }
}
