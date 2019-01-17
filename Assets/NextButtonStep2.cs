﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButtonStep2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button doneButton = GameObject.Find("DoneButton").GetComponent<Button>();
        doneButton.onClick.AddListener(NextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextScene()
    {
        SceneManager.LoadScene("Simulator");
    }
}
