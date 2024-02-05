public class Circle : Shape{
    private double _radius;
    protected string _name;
    public Circle(string color, double radius) : base(color){
        _radius = radius;
        _name = "circle";
    }
    public override double GetArea(){
        return double.Round(_radius*_radius*Math.PI,2);
    }
    public void SetRadius(double radius){
        _radius = radius;
    }
    public double GetRadius(){
        return _radius;
    }
}