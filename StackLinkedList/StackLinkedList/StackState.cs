namespace StackLinkedList;

public class StackState
{

    public List<int?> _current;
    public Stack.StackOperation _stackOperations;
    public int? _data;
    public StackState(List<int?> current, Stack.StackOperation stackOperations, int? data)
    {
        _current = current;
        _stackOperations = stackOperations;
        _data = data;
    }
}
