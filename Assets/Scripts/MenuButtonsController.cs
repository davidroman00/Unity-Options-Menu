using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonsController : MonoBehaviour
{
    [SerializeField]
    GameObject _optionsScreen;
    [SerializeField]
    GameObject _mainScreen;
    public void BackButton()
    {
        _optionsScreen.SetActive(false);
        _mainScreen.SetActive(true);
    }
    public void OptionsButton()
    {
        _optionsScreen.SetActive(true);
        _mainScreen.SetActive(false);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
}
