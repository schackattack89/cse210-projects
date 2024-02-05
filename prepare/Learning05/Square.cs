public class Square : Shape{
    private double _side;
    protected string _name;
    public Square(string color, double side) : base(color){
        _side = side;
        _name = "square";
    }
    public override double GetArea(){
        return double.Round(_side*_side,2);
    }
    public void SetSide(double side){
        _side = side;
    }
}