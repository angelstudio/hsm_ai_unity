using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{

    InputField inputField;
    public string inputValue = "";


    // 初期化
    void Start()
    {
        inputField = GetComponent<InputField>();

        InitInputField();
    }

    // ログ出力
    public void InputLogger()
    {
        inputValue = inputField.text;

        Debug.Log(inputValue);

        InitInputField();
    }

    // フィールドを初期化してフォーカスを当てる
    void InitInputField()
    {
        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }

}