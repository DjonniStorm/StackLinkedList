namespace StackLinkedList;

public class StackAdministrator
{
    private Stack? _stack;
    private StackStorage? _storage;

    public StackAdministrator()
    {
        _stack = new Stack();
        _storage = new StackStorage();
    }
    public void SetMaxCount(int value)
    {
        if (value > 0)
        {
            _storage.MaxStateSize = value;
        }
    }
    public bool CantMakeStep()
    {
        return _storage.Additional == _storage.MaxStateSize;
    }

    public StackStorage Step(Stack.StackOperation stackOperation, StackParameter? stackParameter = default, bool canAddToStorage = true)
    {
        _stack.Step(stackOperation, stackParameter);
        if (canAddToStorage)
            _storage.AddState(_stack.GetStackState());
        return _storage;
    }
    public StackStorage StepForward()
    {
        _storage.StepForward();
        return _storage;
    }

    public StackStorage StepBackward()
    {
        _storage.StepBackward();
        return _storage;
    }

    public StackStorage LastStep()
    {
        _storage.GetLastState();
        return _storage;
    }
    public bool CanMakeOperation()
    {
        return _storage.Count - 1 == _storage.StateIndex;
    }
    public bool Save(string filename)
    {
        return _storage.Save(filename);
    }
    public bool Load(string filename)
    {
        if (_storage.Load(filename))
        {
            if (_storage._states == null) return false;
            
            foreach (var state in _storage._states.ToList())
            {
                Step(state._stackOperations, new StackParameter(state._data), false);
            }
            return true;
        }
        return false;
    }
}