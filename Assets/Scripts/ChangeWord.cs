using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ChangeWord : MonoBehaviour {    
    [SerializeField]private GameObject word;
    private System.Random randomWord = new System.Random();
    private string chosenWord;
    private void Start()
    {
        ShowWord();
    }  
    private void OnMouseUpAsButton()
    {
        ShowWord();
    }
    private void ShowWord()
    {
        switch (LanguageButtons.language)
        {
            case "Armenian":
                ChooseWord("/WordFiles/armenianWords.txt");
                break;
            case "Russian":
                ChooseWord("/WordFiles/russianWords.txt");
                break;
            case "English":
                ChooseWord("/WordFiles/englishWords.txt");
                break;
            case "Arabian":
                ChooseWord("/WordFiles/arabianWords.txt");
                break;
            case "German":
                ChooseWord("/WordFiles/germanWords.txt");
                break;
        }
    }
    private void ChooseWord(string name)
    {
        string fileName = name;
        string filePath = Application.dataPath + fileName;
        string[] words = File.ReadAllText(filePath).Split(',');
        chosenWord = words[randomWord.Next(0, words.Length)];
        word.GetComponent<Text>().text = chosenWord;
    }
}
