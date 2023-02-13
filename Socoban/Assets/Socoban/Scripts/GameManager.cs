using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public _0208_Itembox[] itemBoxes;
    public bool isGameOver;
    public GameObject winUI;
    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if(isGameOver == true)
        {
            return;
        }
        int count = 0;
        for(int i = 0; i < itemBoxes.Length; i++)
        {
            if(itemBoxes[i].isOveraped == true)
            {
                //count = count +1;
                count++;
            }
        }
        if(count >= 3)
        {
            isGameOver = true;
            winUI.SetActive(true);
            Debug.Log("°ÔÀÓ ½Â¸®");
        }
    }
}
