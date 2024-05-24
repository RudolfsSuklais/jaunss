using System.Collections;
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

    public void getText()
    {
  
        text = inputField.GetComponent<InputField>().text;
        year = inputFieldYear.GetComponent<InputField>().text;

      
        if (int.TryParse(year, out int parsedYear))
        {
         
            calculatedYear = 2024 - parsedYear;

            
            displayField.GetComponent<Text>().text = $"{text}, {calculatedYear}";
        }
        else
        {
            
            displayField.GetComponent<Text>().text = "Invalid year input.";
        }
    }

}
