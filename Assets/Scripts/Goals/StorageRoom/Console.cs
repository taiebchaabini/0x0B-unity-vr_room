using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Console : MonoBehaviour
{
    // Collects multiple gameobjects that contains the code
    public List<GameObject> keys; 
    // Gets Console's typed code.
    public InputField codeInputField;

    private TMP_Text inputCodeTMP;
    private int inputCode;
    private int code;
    // Start is called before the first frame update
    void Start()
    {
        code = 9874;
        inputCodeTMP = codeInputField.transform.Find("Text").GetComponent<TMP_Text>();
    }

    // Reset the code on the console
    public void resetCode()
    {

    }

    // Check if the code is correct
    // Opens the door or Shows up an error if the code is not correct
    public void checkCode()
    { 
        inputCode = int.Parse(inputCodeTMP.text);
        if (inputCode == code)
            // Open the door
            Debug.Log("Open Door");

        else
            // Make error massage animation
            Debug.Log("Animation");
    }
}
