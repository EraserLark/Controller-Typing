using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{
    GameObject optionPanel;
    public bool isOpen = false;

    private void Awake()
    {
        optionPanel = gameObject;
        moveOptionPanel(isOpen);
    }

    public void buttonPress()
    {
        isOpen = !isOpen;
        moveOptionPanel(isOpen);
    }

    void moveOptionPanel(bool panelIsOpen)
    {
        if(panelIsOpen)
        {
            optionPanel.transform.Translate(-300f, 0f, 0f, Space.World);
        }
        else if(!panelIsOpen)
        {
            optionPanel.transform.Translate(300f, 0f, 0f, Space.World);
        }
    }
}
