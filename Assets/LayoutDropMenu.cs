using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutDropMenu : MonoBehaviour
{
    LetterData letterData;
    Dropdown dropdownMenu;
    MenuManager menuManager;
    Image halloweenBG;

    private void Awake()
    {
        letterData = GameObject.Find("LetterData").GetComponent<LetterData>();
        menuManager = GameObject.Find("MenuManager").GetComponent<MenuManager>();
        halloweenBG = GameObject.Find("BG_Halloween").GetComponent<Image>();
        dropdownMenu = gameObject.GetComponent<Dropdown>();

        //Runs when user chooses new option from dopdown
        dropdownMenu.onValueChanged.AddListener(delegate { changePreset(dropdownMenu); });
    }

    private void Start()
    {
        halloweenBG.gameObject.SetActive(false);

        dropdownMenu.ClearOptions();

        List<string> presetNames = new List<string>();
        foreach(LetterGroup group in letterData.presets)
        {
            presetNames.Add(group.groupName);
        }

        dropdownMenu.AddOptions(presetNames);
    }

    public void changePreset(Dropdown menu)
    {
        menuManager.setMenuPreset(letterData.presets, menu.value);
        changeHalloweenBG(menu.value);
    }

    void changeHalloweenBG(int value)
    {
        if(value == 3)
        {
            halloweenBG.gameObject.SetActive(true);
        }
        else
        {
            halloweenBG.gameObject.SetActive(false);
        }
    }
}
