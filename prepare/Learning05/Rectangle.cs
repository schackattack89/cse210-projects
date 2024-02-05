public class Rectangle : Shape{
    private double _length;
    private double _width;
    protected string _name;
    public Rectangle(string color, double length, double width) : base(color){
        _length = length;
        _width = width;
        _name = "rectangle";
    }
    public override double GetArea(){
        return double.Round(_length*_width,2);
    }
    public void SetLength(double length){
        _length = length;
    }
    public void SetWidth(double width){
        _width = width;
    }
    public double GetLength(){
        return _length;
    }
    public double GetWidth(){
        return _width;
    }
}