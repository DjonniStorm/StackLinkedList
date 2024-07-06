using System.Text;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StackLinkedList;

public class StackStorage
{
    public List<StackState> _states;
    private const string datakey = "y";
    private const char sepatator = '|';

    private int _currentStateIndex;
    public int StateIndex
    {
        get => _currentStateIndex;
    }
    public int Count => _states.Count;
    private int additionalCounter = 0;
    public int Additional
    {
        get => additionalCounter;
    }
    public int MaxStateSize { get; set; }

    public StackStorage()
    {
        _states = new();
        _currentStateIndex = 0;
    }

    public void AddState(StackState state)
    {
        if (state._stackOperations.Equals(Stack.StackOperation.Pop3) && Count > 0)
        {
            additionalCounter--;
        }
        if (MaxStateSize == additionalCounter)
        {
            return;
        }
        if (state._stackOperations.Equals(Stack.StackOperation.Push5))
        {
            additionalCounter++;
        } 
        if (Count > 0)
        {
            _currentStateIndex++;
        }
        _states.Add(state);
    }

    public StackState? GetState(int index)
    {
        if (index < 0 || index >= Count) return null;
        _currentStateIndex = index;
        return _states[index];
    }

    public void StepForward()
    {
        if (_currentStateIndex + 1 >= Count) return;
        _currentStateIndex++;
    }
    
    public void StepBackward()
    {
        if (_currentStateIndex == 0) return;
        _currentStateIndex--;
    }

    public StackState? GetFirstState()
    {
        return GetState(0);
    }

    public StackState? GetCurrentState()
    {
        return GetState(_currentStateIndex);
    }


    public StackState? GetLastState()
    {
       // CurrentStateIndex = _states.Count;
        return GetState(_currentStateIndex);
    }

    public bool Save(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(datakey);
                writer.WriteLine(_currentStateIndex);
               // MessageBox.Show(_currentStateIndex.ToString());
                foreach (var state in _states)
                {
                    StringBuilder line = new();
                    for (int i = 0; i < state._current.Count; i++)
                    {
                        line.Append(state._current[i] + sepatator.ToString());
                    }
                    writer.WriteLine(datakey + ";" + line + ";" + state._stackOperations + ";" + state._data);
                }
                return true;
            }
        } catch (Exception)
        {
            return false;
        }
    }
    public bool Load(string filename)
    {
        if (!File.Exists(filename))
        {
            return false;
        }
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _states.Clear();
                //строка из файла
                string text = "";
                text = reader.ReadLine();
                if (!text.Equals(datakey)) throw new Exception();
                if (Int32.TryParse(text = reader.ReadLine(), out var res))
                {
                    _currentStateIndex = res - 1;
                  //  MessageBox.Show(_currentStateIndex.ToString());
                }
                while ((text = reader.ReadLine()) != null)
                {
                    //для данных
                    string[] line = new string[4];
                    text = text.Trim(); //- лишние символы по бокам
                    line = text.Split(";"); //теперь там все данные
                    Stack.StackOperation operation = (Stack.StackOperation)Enum.Parse(typeof(Stack.StackOperation), line[2], true); //парсим операцию
                    List<int?> data = new();
                    //MessageBox.Show($"{line[1]}");
                    string[] curr = line[1].Split(sepatator);
                    for (int i = 0; i < curr.Length; i++)
                    {
                        if (Int32.TryParse(curr[i], out var val))
                        {
                            data.Add(val);
                        }
                    }
                    StackState state1 = new(data, operation, Int32.TryParse(line[3], out var tmp) ? tmp : null);
                    _states.Add(state1);
                }
                return true;
            }
        } catch(Exception)
        {
            return false;
        }
    }
}