using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackLinkedList
{
    public partial class FormVisualization : Form
    {
        private StackAdministrator _administrator;
        private StackVisualizer _stackVisualizer;
        private bool IMakeStep = false; //пригодится
        private Stack.StackOperation? _operation;
        private StackParameter _parameter;
        public FormVisualization()
        {
            InitializeComponent();
            _stackVisualizer = new StackVisualizer();
            _administrator = new StackAdministrator();
            _administrator.SetMaxCount(pictureBox.Width / (pictureBox.Width / 6 + 40) * (pictureBox.Height / (pictureBox.Height / 7 + 40) - 1));
            timer.Enabled = false;

            Draw(_administrator.Step(Stack.StackOperation.RemoveAll));
        }

        private void Draw(StackStorage _stackStorage)
        {
            if (_stackStorage.GetCurrentState() == null)
            {
                return;
            }

            StackState state = _stackStorage.GetCurrentState()!;
            switch (state._stackOperations)
            {
                case Stack.StackOperation.Peek:
                    labelOperationName.Text = "Peek";
                    labelValue.Text = state._data == null ? "Стек пуст" : $"На вершине {state._data}";
                    break;
                case Stack.StackOperation.IsEmpty:
                    labelOperationName.Text = "IsEmpty";
                    labelValue.Text = state._data == 1 ? "Пусто" : "Не пусто";
                    break;
                case Stack.StackOperation.Push1:
                    labelOperationName.Text = "Push";
                    labelValue.Text = $"Новый элемент = {state._current[0]}";
                    break;
                case Stack.StackOperation.Push2:
                    labelOperationName.Text = "Push";
                    labelValue.Text = $"Новый элемент = {state._current[0]}";
                    break;
                case Stack.StackOperation.Push3:
                    labelOperationName.Text = "Push";
                    labelValue.Text = $"Новый элемент = {state._current[0]}";
                    break;
                case Stack.StackOperation.Push4:
                    labelOperationName.Text = "Push";
                    labelValue.Text = $"Новый элемент = {state._current[0]}";
                    break;
                case Stack.StackOperation.Push5:
                    labelOperationName.Text = "Push";
                    labelValue.Text = $"Новый элемент = {state._current[0]}";
                    break;
                case Stack.StackOperation.Pop1:
                    labelOperationName.Text = "Pop";
                    labelValue.Text = state._data == null ? "Стек пуст" : $"Удалённый элемент = {state._data}";
                    break;
                case Stack.StackOperation.Pop2:
                    labelOperationName.Text = "Pop";
                    labelValue.Text = state._data == null ? "Стек пуст" : $"Удалённый элемент = {state._data}";
                    break;
                case Stack.StackOperation.Pop3:
                    labelOperationName.Text = "Pop";
                    labelValue.Text = state._data == null ? "Стек пуст" : $"Удалённый элемент = {state._data}";
                    break;
                default:
                    labelOperationName.Text = "";
                    labelValue.Text = "";
                    break;

            }
            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            _stackVisualizer.Draw(_stackStorage.GetCurrentState()!, g, pictureBox.Size);
            pictureBox.Image = bmp;
        }

        private void ButtonPush_Click(object sender, EventArgs e)
        {
            if (_administrator.CantMakeStep())
            {
                labelOperationName.Text = "Превышено";
                return;
            }
            if (IMakeStep || !_administrator.CanMakeOperation())
            {
                ShowCaution();
                return;
            }
            FormInput formInput = new();
            formInput._parameterDelegate += AddData;
            formInput.Show();
        }

        private void AddData(StackParameter parameter)
        {
            _operation = Stack.StackOperation.Push1;
            IMakeStep = true;
            _parameter = parameter;
            timer.Enabled = true;
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            FormInformation form = new();
            form.Show();
        }

        private void ButtonPop_Click(object sender, EventArgs e)
        {
            if (IMakeStep || !_administrator.CanMakeOperation())
            {
                ShowCaution();
                return;
            }
            IMakeStep = true;
            _operation = Stack.StackOperation.Pop1;
            timer.Enabled = true;
        }
        private void ButtonPeek_Click(object sender, EventArgs e)
        {
            if (IMakeStep || !_administrator.CanMakeOperation())
            {
                ShowCaution();
                return;
            }
            Draw(_administrator.Step(Stack.StackOperation.Peek));
        }
        private void ButtonIsEmpty_Click(object sender, EventArgs e)
        {
            if (IMakeStep || !_administrator.CanMakeOperation())
            {
                ShowCaution();
                return;
            }
            Draw(_administrator.Step(Stack.StackOperation.IsEmpty));
        }
        private void ButtonStepForward_Click(object sender, EventArgs e)
        {
            if (IMakeStep)
            {
                ShowCaution();
                return;
            }
            Draw(_administrator?.StepForward()!);
        }

        private void ButtonStepBack_Click(object sender, EventArgs e)
        {
            if (IMakeStep)
            {
                ShowCaution();
                return;
            }
            Draw(_administrator?.StepBackward()!);
        }
        private void ShowCaution()
        {
            labelOperationName.Text = "Не закончено";
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_administrator.Save(saveFileDialog.FileName))
                {
                    labelOperationName.Text = "Сохранение";
                }
                else
                {
                    labelOperationName.Text = "Не удалось сохранить";
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOperationName.Text = "Загрузка";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_administrator.Load(openFileDialog.FileName))
                {
                    labelValue.Text = "Загрузка";
                }
                else
                {
                    labelValue.Text = "Не удалось загрузить";
                }
            }
            try
            {
                var state = _administrator.StepForward();
                Draw(state);
            }
            catch (Exception) { }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (IMakeStep)
                {
                    ShowCaution();
                    return;
                }
                Draw(_administrator.StepBackward());
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                if (IMakeStep)
                {
                    ShowCaution();
                    return;
                }
                Draw(_administrator.StepForward());
            }
        }
        private int counter = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IMakeStep)
            {
                if (_operation.Equals(Stack.StackOperation.Push1))
                {
                    if (counter > 4)
                    {
                        IMakeStep = false;
                        _operation = null;
                        counter = 0;
                        _parameter = null;
                        timer.Enabled = false;
                        return;
                    }
                    counter++;
                    Stack.StackOperation operation = (Stack.StackOperation)Enum.Parse(typeof(Stack.StackOperation), $"Push{counter}", true);
                    Draw(_administrator.Step(operation, _parameter));
                } else if (_operation.Equals(Stack.StackOperation.Pop1))
                {
                    if (counter > 2)
                    {
                        IMakeStep = false;
                        _operation = null;
                        counter = 0;
                        timer.Enabled = false;
                        return;
                    }
                    counter++;
                    Stack.StackOperation operation = (Stack.StackOperation)Enum.Parse(typeof(Stack.StackOperation), $"Pop{counter}", true);
                    Draw(_administrator.Step(operation));
                }
            }
        }
    }
}