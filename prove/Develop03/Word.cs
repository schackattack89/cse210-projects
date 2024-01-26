using System.Net.Mime;

public class Word{
    private string _text;
    private bool _isHidden = false;
    public Word(string text){
        _text = text;
    }
    public string GetDisplayText(){
        return _text;
    }
    public void Hide(){
        int wordLength = _text.Length;
        string hiddenText = "";
        for(int i = 0; i<wordLength; i++){
            hiddenText += "_";
        }
        _text = hiddenText;
    }
    public void Show(){

    }
    public bool isHidden(){
        if(_text.Contains('_')){
            _isHidden = true;
        }
        return _isHidden;
    }
}