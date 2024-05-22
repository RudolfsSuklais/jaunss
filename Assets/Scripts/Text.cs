using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{

    string text;
    public GameObject inputField;
    public GameObject displayField;
    public void getText()
    {
      
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = text.ToLower() + "!";
    }
}
