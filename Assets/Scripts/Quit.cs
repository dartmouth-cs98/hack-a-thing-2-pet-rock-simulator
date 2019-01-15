using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//Code adapted from https://www.youtube.com/watch?v=4-X1FDylROA
public class Quit : MonoBehaviour
{
    public void toQuit()
    {
        Debug.Log("Player has Quit Game");
        Application.Quit();
    }

}
