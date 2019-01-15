using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats 
{
    private static string rockName;
    private static string typeOfRock;
    private static ArrayList accessories = new ArrayList();

    public static string RockName
    {
        get
        {
            return rockName;
        }
        set
        {
            rockName = value;
        }
    }

    public static string TypeOfRock
    {
        get
        {
            return typeOfRock;
        }
        set
        {
            typeOfRock = value;
        }
    }

    public static ArrayList Accessories
    {
        get
        {
            return accessories;
        }
        set
        {
            accessories = value;
        }
    }




}
