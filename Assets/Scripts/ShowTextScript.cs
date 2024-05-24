﻿using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    string text;
    string year;
    int calculatedYear;
    public GameObject inputField;
    public GameObject inputFieldYear;
    public GameObject displayField;
    public GameObject scrollView;
    public GameObject character;
    string Character;

    public void getCharacter(int index)
    {
        if (index == 0)

            Character = "balts";

        else
            Character = "melns";
    }
    public void getText()
    {
  
        text = inputField.GetComponent<InputField>().text;
        year = inputFieldYear.GetComponent<InputField>().text;

      
        if (int.TryParse(year, out int parsedYear))
        {
         
            calculatedYear = 2024 - parsedYear;


            scrollView.GetComponent<Text>().text = $"Name: {text}\nAge:{calculatedYear}" +
                $"\nCharacter: "+Character;
        }
        else
        {

            scrollView.GetComponent<Text>().text = "Invalid year input.";
        }
    }

    

    
}
