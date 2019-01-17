using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This code was adapted from https://www.youtube.com/watch?v=4rZAAHevq1s
public class spawn_Rock : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody rock;
    public Rigidbody rock_small_prefab;
    public Rigidbody rock_medium_prefab;
    public Rigidbody rock_large_prefab;
    public Transform Rock_instantiation;
    // Start is called before the first frame update
    void Start()
    {
        string rock_Name=PlayerStats.RockName;
        string type_rock = PlayerStats.TypeOfRock;
       // string type_rock = "REMOVE";
        ArrayList accessories = PlayerStats.Accessories;

        if (type_rock == "rock_small")
        {

            rock = Rigidbody.Instantiate(rock_small_prefab,Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;

        }
        else if (type_rock == "rock_medium")
        {
           
            rock = Rigidbody.Instantiate(rock_medium_prefab, Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;
        }
        else
        {
         
        rock = Rigidbody.Instantiate(rock_large_prefab, Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;
        }


      //  rock = Instantiate(rock_medium_prefab, Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rock.AddForce(movement * speed);

    }
}
