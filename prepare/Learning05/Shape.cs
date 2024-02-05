public class Shape{
    private string _color;
    private string _name;
    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }
    public Shape(string color){
        _color = color;
        _name = "";
    }
    public virtual double GetArea(){
        return 0;
    } 
    public string GetName(){
        return _name;
    }
}