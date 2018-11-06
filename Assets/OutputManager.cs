using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputManager : MonoBehaviour {

    Text text;
    public InputField inputField;
    InputManager inputManager;

    void Start()
    {
        inputManager = inputField.GetComponent<InputManager>();

        text = GetComponent<Text>();

    }

    private void Update()
    {
        text.text = inputManager.inputValue;
    }
}
