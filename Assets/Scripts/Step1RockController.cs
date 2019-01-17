using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Step1RockController : MonoBehaviour
{
    public Text rockName;
    private string rockType;
    private GameObject smallRock;
    private GameObject mediumRock;
    private GameObject largeRock;
    private GameObject rockNameInput;


    private void Start()
    {
        Button doneButton = GameObject.Find("DoneButton").GetComponent<Button>();
        doneButton.onClick.AddListener(SetStats);
    }


    void SetStats()
    {
        smallRock = GameObject.Find("rock_small");
        mediumRock = GameObject.Find("rock_medium");
        largeRock = GameObject.Find("rock_large");
        rockNameInput = GameObject.Find("InputName");
        InputField rockNameInputField = rockNameInput.GetComponent<InputField>();

        if (smallRock != null && mediumRock.activeSelf)
        {
            Debug.Log("small Button clicked!");
            PlayerStats.TypeOfRock = smallRock.name;

        }
        else if (mediumRock != null && mediumRock.activeSelf)
        {
            Debug.Log("medium Button clicked!");
            PlayerStats.TypeOfRock = mediumRock.name;
        }
        else if (largeRock != null && largeRock.activeSelf)
        {
            Debug.Log("large Button clicked!");
            PlayerStats.TypeOfRock = largeRock.name;
        }
        else
        {
            Debug.Log("nothing was found");
        }

        PlayerStats.RockName = rockNameInputField.text;
        Debug.Log("Playerstats: ");
        Debug.Log("name: " + PlayerStats.RockName);
        Debug.Log("rock type: " + PlayerStats.TypeOfRock);

        SceneManager.LoadScene("step_2");
    }
}

