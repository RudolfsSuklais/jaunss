using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    string text;
    string year;
    public GameObject inputField;
    public GameObject inputFieldYear;
    public GameObject displayField;

    public void getText()
    {
       
        text = inputField.GetComponent<Text>().text;
        year = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = text+year;
    }

}
