using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeybindingTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(MenuButtonsController.KeybindingText))
        {
            GetComponent<TextMeshProUGUI>().text = "mememememme";
        }
    }
}
