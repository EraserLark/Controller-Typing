using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInput : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        var allGamepads = Gamepad.all;
        print(allGamepads);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
