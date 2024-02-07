public class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amount = 0, bool complete = false) : base(name, description, points){
        _isComplete = complete;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }
    public override void RecordEvent(){
        _amountCompleted++;
        if(IsComplete()){
            int earnedBonus = Convert.ToInt32(_points) + _bonus;
            _points = earnedBonus.ToString();
        }
    }
    public override bool IsComplete(){
        if(_amountCompleted == _target){
            _isComplete = true;
        }
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return $"Checklist Goal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}|{_isComplete}";
    }
    public override string GetDetailsString(){
        string details = "";
        if(IsComplete()){
            details = $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else{
            details = $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        return details;
    }
    public override void SetIsComplete(bool modifyComplete){
        _isComplete = modifyComplete;
        _amountCompleted = 0;
    }
}