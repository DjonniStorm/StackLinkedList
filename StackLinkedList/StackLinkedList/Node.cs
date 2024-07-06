namespace StackLinkedList;

public class Node
{
    public Node? next;
    public int? data;

    public Node()
    {
        data = null;
    }

    public Node(int? _data)
    {
        data = _data;
    }
    
    public override string ToString()
    {
        return data.ToString()?? "Пусто";
    }
}