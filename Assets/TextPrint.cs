using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPrint : MonoBehaviour
{
    TextMeshProUGUI textArea;

    private void Awake()
    {
        textArea = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void PrintMessage(string message)
    {
        textArea.text += ("\n>> " + message);
    }
}
