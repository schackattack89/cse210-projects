using System.Runtime.CompilerServices;

public class Scripture{

    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public bool isCompletelyHidden = false;

    public Scripture(Reference reference, string text){
        _reference = reference;
        string[] textArray = text.Split(' ');
        foreach(string wordText in textArray){
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide){
        int listLength = _words.Count();
        Random randomGenerator = new Random();
        for(int i=0; i<numberToHide; i++){
            int wordIndex = randomGenerator.Next(0,listLength);
            if(_words[wordIndex].isHidden() && !IsCompletelyHidden()){
                i--;
            }
            _words[wordIndex].Hide();
        }
    }
    public string GetDisplayText(){
        string displayText = "";
        foreach(Word word in _words){
            displayText += word.GetDisplayText();
            displayText += " ";
        }
        return displayText;
    }
    public bool IsCompletelyHidden(){
        int verseLength = _words.Count();
        int hiddenCount = 0;
        foreach(Word word in _words){
            if(word.GetDisplayText().Contains('_')){
                hiddenCount ++;
            }
        }
        if(verseLength == hiddenCount){
            isCompletelyHidden = true;
        }
        return isCompletelyHidden;
    }
}