using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Load_accessories_rock : MonoBehaviour
{

    public GameObject rock;
    public GameObject eyes;
    public GameObject smile;
    public GameObject glasses;
    public GameObject hat;
    public GameObject rock_small;
    public GameObject rock_medium;
    public GameObject rock_large;
    //public Transform Rock_instantiation;

    // Start is called before the first frame update
    void Start()
    {
        string rock_Name = PlayerStats.RockName;
        string type_rock = PlayerStats.TypeOfRock;
        // string type_rock = "REMOVE";
        ArrayList accessories = PlayerStats.Accessories;

        if (type_rock == "rock_small")
        {
            rock = Instantiate(rock_small) as GameObject;
            List<GameObject> returnedAccessories = LoadAccessories();
            
            //  rock = Instantiate(rock_small_prefab, Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;

        }
        else if (type_rock == "rock_medium")
        {
            rock = Instantiate(rock_medium) as GameObject;
            List<GameObject> returnedAccessories = LoadAccessories();
            //  rock = Instantiate(rock_medium_prefab, Rock_instantiation.position, Rock_instantiation.rotation) as Rigidbody;
        }
        else
        {
            Debug.Log("made it here!");
            rock = Instantiate(rock_large) as GameObject;
            List<GameObject> returnedAccessories = LoadAccessories();
            // eyes
            Vector3 currentEyePosition = returnedAccessories[0].transform.localPosition;
       //     currentEyePosition.Set((float)-0.2956, (float)-0.0082, (float)-0.054);
       //     returnedAccessories[0].transform.Rotate((float)0.0, (float)-93.23601, (float)0.0);
            //smile
        //    Vector3 currentSmilePosition = returnedAccessories[1].transform.localPosition;
          //  currentSmilePosition.Set((float)0.0347, (float)0.019, (float)-0.1624);
       //     returnedAccessories[0].transform.Rotate((float)0.0, (float)-91.82001, (float)1.43229);

                            //  smile
              //  returnedAccessories[1].transform.position = new Vector3((float)-0.2956, (float)-0.0082, (float)-0.07  269996); 
              //  returnedAccessories[1].transform.Rotate((float)0.0, (float)-93.23601,     (float)

                

            

            //     rock = Instaab, Rock_instantiation.position, Rock_instan
                }
        rock.SetActive(true);

    }

    List<GameObject> LoadAccessories () {
        Transform rockTransform = rock.transform;
        eyes = Instantiate(eyes) as GameObject;
      //  smile = Instantiate(smile) as GameObject;
        glasses = Instantiate(glasses) as GameObject;
        hat = Instantiate(hat) as GameObject;

        eyes.transform.SetParent(rock.transform);
      //  smile.transform.SetParent(rock.transform);
        glasses.transform.SetParent(rock.transform);
        hat.transform.SetParent(rock.transform);
        
        List<GameObject> toReturn = new List<GameObject>();
        toReturn.Add(eyes);
   //     toReturn.Add(smile);
        toReturn.Add(glasses);
        toReturn.Add(hat);
        return toReturn;

               //eyes.transform.parent = Selection.act

        //smile.transform.parent gameObject.

        //glasses.transform.parent =gameObje

        //hat.transform.parent = gameObject.transform;
    }

}

