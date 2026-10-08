public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description} - {_points} points";
    }

    public int GetPoints()
    {
        return _points;
    }
}