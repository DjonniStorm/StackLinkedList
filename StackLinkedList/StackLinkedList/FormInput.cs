namespace StackLinkedList;

public partial class FormInput : Form
{
    private StackParameter? _parameter;
    public event Action<StackParameter>? _parameterDelegate;
    public FormInput()
    {
        InitializeComponent();
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        _parameter = new StackParameter((int)numericUpDownInput.Value);
        _parameterDelegate?.Invoke(_parameter);
        Close();
    }
}
