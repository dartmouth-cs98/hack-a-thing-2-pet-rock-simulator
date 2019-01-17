using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // MyRock = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, -15, 0) * Time.deltaTime);
        
    }
}
