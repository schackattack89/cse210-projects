using System.Runtime.CompilerServices;

public class SimpleGoal : Goal{
    //private bool _isComplete;
    
    public SimpleGoal(string name, string description, string points, bool complete = false) : base(name, description, points){
        _isComplete = complete;
    }
    public override void RecordEvent(){
        _isComplete = true;

    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return $"Simple Goal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}