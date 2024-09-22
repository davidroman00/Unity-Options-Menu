using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuButtonsController : MonoBehaviour
{
    [SerializeField]
    GameObject _optionsScreen;
    [SerializeField]
    GameObject _mainScreen;
    [SerializeField]
    GameObject _dropdown;
    [SerializeField]
    GameObject _selectedOption;
    TextMeshProUGUI _selectedText;
    void Awake()
    {
        _selectedText = _selectedOption.GetComponentInChildren<TextMeshProUGUI>();
    }
    public void BackButton()
    {
        _optionsScreen.SetActive(false);
        _mainScreen.SetActive(true);
    }
    public void ShowHideResolutionDrowpdown()
    {
        _dropdown.SetActive(!_dropdown.activeInHierarchy);
    }
    public void Select1920x1080Option()
    {
        _selectedText.text = "1920x1080";
        _dropdown.SetActive(false);
        Screen.SetResolution(1920, 1080, true);
    }
    public void Select1600x900Option()
    {
        _selectedText.text = "1600x900";
        _dropdown.SetActive(false);
        Screen.SetResolution(1600, 900, false);
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
