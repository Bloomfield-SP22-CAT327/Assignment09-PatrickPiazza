using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveManager : MonoBehaviour
{
    public GameObject Title;
    public GameObject NewGame;
    public GameObject game;

    public InputField writer;
    public TextMeshProUGUI displayText;

    public void ShowMainMenu()
    {
        Title.SetActive(true);
        NewGame.SetActive(false);
        game.SetActive(false);
    }

    public void ShowNewGame()
    {
        Title.SetActive(false);
        NewGame.SetActive(true);
        game.SetActive(false);
        Data.display = new Data();
        writer.text = Data.display.wordsNShit.words;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SaveNStart()
    {
        Data.display.wordsNShit.words = writer.text;
        Loader.Save();
        Title.SetActive(false);
        NewGame.SetActive(false);
        game.SetActive(true);
        displayText.text = Data.display.wordsNShit.words;
    }

    public void LoadGame()
    {
        Loader.Load();
    }
}
