using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ChangeWord : MonoBehaviour {    
    [SerializeField]private Text _word;
    private System.Random _randomWord = new System.Random();
    private int _languageNumber;
    private string _filePath;
    private string[] _words;
    private string[] _fileNames =
    {
        "/WordFiles/armenianWords.txt",
        "/WordFiles/russianWords.txt",
        "/WordFiles/englishWords.txt",
        "/WordFiles/arabianWords.txt",
        "/WordFiles/germanWords.txt"
    };
    private void Start()
    {
        FileSettings();
        ChooseWord();
    }

    private int LanguageCheck()
    {
        int i = 0; 
        switch (LanguageButtons.Language)
        {
            case "Armenian":
                i = 0;
                break;
            case "Russian":
                i = 1;
                break;
            case "English":
                i = 2;
                break;
            case "Arabian":
                i = 3;
                break;
            case "German":
                i = 4;
                break;
        }
        return i;
    }

    private void FileSettings()
    {
        _languageNumber = LanguageCheck();
        _filePath = Application.dataPath + _fileNames[_languageNumber];
        _words = File.ReadAllText(_filePath).Split(',');
    }
    public void ChooseWord()
    {
        _word.text = _words[_randomWord.Next(0, _words.Length)];
    }
}
