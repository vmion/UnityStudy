using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0209_ScoreManager : MonoBehaviour
{
    //public int[] scores = new int[10];
    //public List<int> scores = new List<int>();
    //int index = 0;
    public static _0209_ScoreManager instance;
    public static _0209_ScoreManager GetInstance()
    {
        if(instance == null)
        {
            //instance = FindObjectOfType<_0209_ScoreManager>();
            GameObject container = new GameObject("ScoreManager");
            instance = container.AddComponent<_0209_ScoreManager>();
        }

        return instance;
    }
    private int score = 0;
    //private void Awake()
    //{
    //    instance = this;
    //}
    public int GetScore()
    {
        return score;
    }
    public void AddScore(int newScore)
    {
        score = score + newScore;
    }
    private void Start()
    {
        //int score0 = 45;
        //int score1 = 60;
        //int score2 = 75;

        //scores.Add(score0);
        //scores.Add(score1);
        //scores.Add(score2);

        //scores.Remove(60);
        
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    scores[index] = Random.Range(0, 100);
        //    index++;
        //}        
    }
}
