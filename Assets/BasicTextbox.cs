using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicTextbox : MonoBehaviour
{
    TextMeshProUGUI textField;

    private void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();
    }

    public void addLetter(char character)
    {
        textField.text += character;
    }

    public void deleteLetter()
    {
        int charPosToRemove = (textField.text.Length - 1);
        textField.text = textField.text.Remove(charPosToRemove, 1);
    }
}
