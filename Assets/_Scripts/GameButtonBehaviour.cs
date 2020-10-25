﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked_Win()
    {
        FindObjectOfType<AudioManager>().PlaySound("ButtonSelect");
        SceneManager.LoadScene("Win");
    }

    public void OnClicked_Lose()
    {
        SceneManager.LoadScene("Lose");
    }
}
