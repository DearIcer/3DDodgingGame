using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager GameManager ; 

    // Update is called once per frame
    private void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        AddScore(GameManager);
    }
    
    void AddScore(IGameManager gameManager)
    {
        if (transform.position.y < -10)
        {
            gameManager.OnNotify();
            Destroy(gameObject);
        }
    }
}
