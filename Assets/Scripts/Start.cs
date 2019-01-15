using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//Adapted from https://www.youtube.com/watch?v=5x2tDagmFiQ
public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public void toStart()
    {
        SceneManager.LoadScene("step_1");
    }
}
