public class Fraction{

    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int Top){
        _top = Top;
        _bottom = 1;
    }

    public Fraction(int Top, int Bottom){
        _top = Top;
        _bottom = Bottom;
    }

    private int GetTop()
    {
        return _top;
    }
    private int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int Top){
        _top=Top;
    }
    public void SetBottom(int Bottom){
        _bottom = Bottom;
    }

    public void GetFractionString(){
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}
