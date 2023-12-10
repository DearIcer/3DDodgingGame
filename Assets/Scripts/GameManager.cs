using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour,IGameManager
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public GameObject stone;
    public float maxPos ;
    public Transform spwanPointPos;
    void Start()
    {
        InvokeRepeating("SpawnStone", 1.0f, 1.0f);
    }
    
    void SpawnStone()
    {
        var position = spwanPointPos.position;
        position.z = Random.Range(-maxPos, maxPos);
        Instantiate(stone, position, Quaternion.identity);
    }

    public void OnNotify()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
