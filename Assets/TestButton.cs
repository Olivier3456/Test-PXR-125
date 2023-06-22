using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public TextMeshProUGUI debugText;

    private void Start()
    {
        debugText.text = "Waiting for button press.";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))  // Doesn't work.
        {
            debugText.text = "The Confirm button has been pressed";
            StartCoroutine(StopDisplay());
        }
        else if (Input.GetKeyDown(KeyCode.Escape))      // Works well.
        {
            debugText.text = "The Return button has been pressed.";
            StartCoroutine(StopDisplay());
        }
    }



    IEnumerator StopDisplay()
    {
        yield return new WaitForSeconds(2);
        debugText.text = "Waiting for button press.";
    }
}
