namespace StackLinkedList;

/// <summary>
/// Класс-параметр для передачи начальных данных
/// </summary>
public class StackParameter
{
    /// <summary>
    /// Данные от пользователя
    /// </summary>
    public int? Data { get; set; }

    public StackParameter(int? data)
    {
        Data = data;
    }
}