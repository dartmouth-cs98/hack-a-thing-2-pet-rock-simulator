using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        string type = PlayerStats.TypeOfRock;
        //string type = "rock_medium";
        if (type == "rock_small")
        {
            player = GameObject.Find("rock_small_prefab(Clone)");

        }
        else if (type == "rock_medium")
        {
            player = GameObject.Find("rock_medium_prefab(Clone)");

        }
        else if (type == "rock_large")
        {
            player = GameObject.Find("rock_large_prefab(Clone)");

        }

        transform.position = player.transform.position + offset;
    }
}
