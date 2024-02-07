public class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;
    public Goal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;

    }
    public virtual void RecordEvent(){
        
    }
    public virtual bool IsComplete(){
        return _isComplete;
    }
    public virtual string GetDetailsString(){
        string details = "";
        if(IsComplete()){
            details = $"[X] {_shortName} ({_description})";
        }
        else{
            details = $"[ ] {_shortName} ({_description})";
        }
        return details;
    }
    public virtual string GetStringRepresentation(){
        return $"Goal|{_shortName}|{_description}|{_points}";
    }
    public int GetPoints(){
        return Convert.ToInt32(_points);
    }
    public string GetName(){
        return _shortName;

    }
    public virtual void SetIsComplete(bool modifyComplete){
        _isComplete = modifyComplete;
    }
}