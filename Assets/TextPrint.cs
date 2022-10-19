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
        textArea.text = textArea.text.Insert(0, "\n>>" + message);
    }
}
