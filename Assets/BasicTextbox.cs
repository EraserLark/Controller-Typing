using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicTextbox : MonoBehaviour
{
    TextMeshProUGUI textField;
    TextPrint textPrint;

    private void Start()
    {
        textField = gameObject.GetComponent<TextMeshProUGUI>();
        textField.text = string.Empty + '|';

        textPrint = GameObject.Find("TextPrint").GetComponent<TextPrint>();
    }

    public void addLetter(char character)
    {
        textField.text = textField.text.Replace('|', character);
        textField.text += '|';
    }

    public void deleteLetter()
    {
        int charPosToRemove = (textField.text.Length - 2);

        if(charPosToRemove >= 0)
        {
            textField.text = textField.text.Remove(charPosToRemove, 1);
        }
    }

    public void submitMessage()
    {
        textField.text = textField.text.Remove(textField.text.Length - 1, 1);   //Remove cursor
        textPrint.PrintMessage(textField.text);
        textField.text = string.Empty + '|';
    }
}
