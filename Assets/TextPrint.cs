using System.IO;
using UnityEngine;
using TMPro;

public class TextPrint : MonoBehaviour
{
    TextMeshProUGUI textArea;
    string messageRecord;
    string path;

    private void Awake()
    {
        textArea = GetComponentInChildren<TextMeshProUGUI>();
        messageRecord += "\n" + System.DateTime.Now.ToString();

        StartTextFile();
    }

    void StartTextFile()
    {
        path = Directory.GetCurrentDirectory() + "/Record.txt";
        if(!File.Exists(path))
        {
            File.WriteAllText(path, "Controller Typing Record\n\n");
        }
    }
    
    public void PrintMessage(string message)
    {
        textArea.text = textArea.text.Insert(0, "\n>> " + message);
        messageRecord += "\n>> " + message;
    }

    public void OnApplicationQuit()
    {
        //print(messageRecord);
        File.AppendAllText(path, messageRecord);
    }
}
