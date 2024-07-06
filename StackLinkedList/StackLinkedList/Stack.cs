namespace StackLinkedList;

public class Stack
{
    public enum StackOperation
    {
        Push1,
        Push2,
        Push3,
        Push4,
        Push5,
        Pop1,
        Pop2,
        Pop3,
        Peek,
        IsEmpty,
        RemoveAll
    }
    
    private StackOperation lastOperation;

    private int? buffer;
    private Node? first = null;

    public Stack()
    {
        first = new();
    }

    //public Stack(StackParameter stackParameter)
    //{
    //    first = new()
    //    {
    //        next = new(stackParameter.Data)
    //    };
    //}

    public void Push(StackParameter stackParameter)
    {
        Node node = new(stackParameter.Data)
        {
            next = first
        };
        first = node;
    }

    public int? Pop()
    {
        if (IsEmpty()) return null;
        Node? temp = first;
        first = first.next;
        return temp.data;
    }
    public bool IsEmpty()
    {
        return first == null;
    }
    public int? Peek()
    {
        if (IsEmpty()) return null;
        return first.data;
    }

    public void RemoveAll()
    {
        first = null;
    }

    public int? Step(StackOperation operation, StackParameter? stackParameter)
    {
        switch (operation)
        {
            case StackOperation.Push1:
                lastOperation = operation;
                
                Push(stackParameter!);
                buffer = stackParameter!.Data!;
                return buffer;
            case StackOperation.Push2:
                lastOperation = operation;
                break;
                Push(stackParameter!);
                buffer = stackParameter!.Data!;
                return buffer;
            case StackOperation.Push3:
                lastOperation = operation;
                break;
                Push(stackParameter!);
                buffer = stackParameter!.Data!;
                return buffer;
            case StackOperation.Push4:
                lastOperation = operation;
                break;
                Push(stackParameter!);
                buffer = stackParameter!.Data!;
                return buffer;
            case StackOperation.Push5:
                lastOperation = operation;
                break;
                Push(stackParameter!);
                buffer = stackParameter!.Data!;
                return buffer;
            //case StackOperation.Push6:
            //    lastOperation = operation;
            //    break;
            //    Push(stackParameter!);
            //    buffer = stackParameter!.Data!;
            //    return buffer;
            case StackOperation.Pop1:
                lastOperation = operation;
                break;
                buffer = Pop();
                return buffer;
            case StackOperation.Pop2:
                lastOperation = operation;
                break;
                buffer = Pop();
                return buffer;
            case StackOperation.Pop3:
                lastOperation = operation;
                
                buffer = Pop();
                return buffer;
            case StackOperation.Peek:
                lastOperation = operation;
                buffer = Peek();
                return buffer;
            case StackOperation.IsEmpty:
                lastOperation = operation;
                buffer = IsEmpty() ? 1 : 0;
                return buffer.Value;
            case StackOperation.RemoveAll:
                RemoveAll();
                break;
            default:
                return null;
        }

        lastOperation = operation;
        return 1;
    }

    /// <summary>
    /// Установка состояния
    /// </summary>
    /// <param name="status"></param>
    public void SetStatus(StackState status)
    {           

        if (status == null) return;
        RemoveAll();
        for (int i = 0; i < status._current.Count; i++)
        {
            Push(new StackParameter(status._current[i]));
        }
    }

    /// <summary>
    /// Метод для объекта состояния
    /// </summary>
    /// <returns></returns>
    public StackState? GetStackState()
    {
        Node stack = first;
        List<int?> stacks = new();
        while (stack != null)
        {
            stacks.Add(stack.data);
            stack = stack.next;
        }
        //stacks.Reverse();
        StackState state = new(stacks, lastOperation, buffer);
        return state;
    }

    
}