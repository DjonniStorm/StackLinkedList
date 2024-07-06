using System.Drawing.Drawing2D;

namespace StackLinkedList;

public class StackVisualizer
{
    public void Draw(StackState state, Graphics g, Size size)
    {
        int width = size.Width / 6;
        int height = size.Height / 7;
        int startX = size.Width / 14;
        int startY = size.Height / 8;
        int betweenSize = 40;
        Pen pen = new(Color.Black, 5f);
        Pen penArrow = new(Color.Black, 3f);
        Pen additionalPen = new(Color.Black, 3f);
        penArrow.CustomEndCap = new AdjustableArrowCap(3, 3);
        Brush backBrush = new SolidBrush(Color.BlanchedAlmond);
        Brush brush  = new SolidBrush(Color.Black);
        Brush additionalBrush = new SolidBrush(Color.AliceBlue);
        Font font = new("Comic Sans MS", (width * height) / (width + height) / 2, FontStyle.Bold | FontStyle.Italic);

        g.DrawRectangle(pen, new Rectangle(startX, startY, width / 2, height));
        g.FillRectangle(backBrush, new Rectangle(startX, startY, width / 2, height));
        g.DrawString("Top", font, brush, new PointF(startX, startY));
        if (state._current == null)
        {
            MessageBox.Show("Беда");
            return;
        }
        int i = 1,
            j = 0, counter = 0;
        if (state._current.Count >= 1)
        {
            //стрелочка от Top
            if (state._current.Count > 1 && !(state._stackOperations.Equals(Stack.StackOperation.Push4))
                && !(state._stackOperations.Equals(Stack.StackOperation.Pop1))
                && !(state._stackOperations.Equals(Stack.StackOperation.Pop2))
                && !state._stackOperations.Equals(Stack.StackOperation.Push2)
                && !state._stackOperations.Equals(Stack.StackOperation.Push3)
                && !state._stackOperations.Equals(Stack.StackOperation.Push4)
                && !state._stackOperations.Equals(Stack.StackOperation.Push1)
                )
            {
                g.DrawLine(penArrow, new Point(startX + width / 4, startY + height),
                    new Point(startX + width / 8 * 3, startY + height + betweenSize));
            }
            //стрелочка от Top к новому элементу стека
            if (state._stackOperations.Equals(Stack.StackOperation.Push2) 
                || state._stackOperations.Equals(Stack.StackOperation.Push3)
                || state._stackOperations.Equals(Stack.StackOperation.Push4)
                || state._stackOperations.Equals(Stack.StackOperation.Push1)
                )
            {
                g.DrawLine(penArrow, new Point(startX + width / 2, startY + height / 2),
                    new Point(size.Width / 5 * 3, startY + height / 2));
            }
            //стрелочка от Top к первому элементу стека
            if ((state._stackOperations.Equals(Stack.StackOperation.Pop3) 
                || state._stackOperations.Equals(Stack.StackOperation.Push5)
                || state._stackOperations.Equals(Stack.StackOperation.Peek)
                || state._stackOperations.Equals(Stack.StackOperation.IsEmpty)) 
                && state._current.Count == 1)
            {
                g.DrawLine(penArrow, new Point(startX + width / 4, startY + height),
                    new Point(startX + width / 8 * 3, startY + height + betweenSize));
            }
            //стрелочка от Top до второго элемента стека, когда Pop
            if ((state._stackOperations.Equals(Stack.StackOperation.Pop1) || state._stackOperations.Equals(Stack.StackOperation.Pop2)) && state._current.Count > 1)
            {
                g.DrawLine(penArrow,
                    new Point(startX + width / 4, startY + height),
                    new Point(startX + width / 2 + width + betweenSize, startY + height + betweenSize)
                    );
            }
        }

        for (counter = 1, j = 1; counter < state._current.Count; counter++, j++)
        {
            if (startX + width * j + betweenSize * j > size.Width - width)
            {
                g.DrawEllipse(new Pen(Color.Orange, 4f), new Rectangle(startX + width * j + betweenSize * j, startY + height * i + betweenSize * i - 10, width / 5, height + 10));
                g.DrawLine(additionalPen, new Point(startX + width * j + betweenSize * j - betweenSize, startY + height * i + betweenSize * i + height / 2),
                new Point(startX + width * j + betweenSize * j + 20, startY + height * i + betweenSize * i + height / 2));
                i++;
                j = 0;
                g.DrawEllipse(new Pen(Color.Blue, 4f), new Rectangle(startX + width * j + betweenSize * j - betweenSize, startY + height * i + betweenSize * i - 10, width / 5, height + 10));
            }
            if (counter > 1)
                g.DrawLine(penArrow, new Point(startX + width * j + betweenSize * j - betweenSize - 15, startY + height * i + betweenSize * i + height / 2), 
                new Point(startX + width * j + betweenSize * j, startY + height * i + betweenSize * i + height / 2));
            g.DrawRectangle(pen, new Rectangle(startX + width * j + betweenSize * j, startY + height * i + betweenSize * i, width, height));
            g.FillRectangle(backBrush, new Rectangle(startX + width * j + betweenSize * j, startY + height * i + betweenSize * i, width, height));
            g.DrawString(state._current[counter].ToString(), font, brush, new PointF(startX + width * j + betweenSize * j + width / 5, 
                startY + height * i + betweenSize * i + height / 5));
            g.FillRectangle(additionalBrush,
                new Rectangle(startX + width * j + betweenSize * j + width / 4 * 3, startY + height * i + betweenSize * i, width / 4, height));
            g.DrawLine(pen, new Point(startX + width * j + betweenSize * j + width / 4 * 3, startY + height * i + betweenSize * i), 
                new Point(startX + width * j + betweenSize * j + width / 4 * 3, startY + height * i + betweenSize * i + height));
            if (counter + 1 == state._current.Count)
            {
                g.DrawLine(additionalPen, new Point(startX + width * j + betweenSize * j + width / 4 * 3, startY + height * i + betweenSize * i),
                    new Point(startX + width * j + betweenSize * j + width, startY + height * i + betweenSize * i + height));
            }
        }
        //тут работаем с 0 элементом в списке данных, чтобы всё было красиво
        switch (state._stackOperations)
        {
            case Stack.StackOperation.Push1:
                g.DrawRectangle(pen, new Rectangle(size.Width / 5 * 3, startY, width, height));
                g.FillRectangle(backBrush, new Rectangle(size.Width / 5 * 3, startY, width, height));
                g.FillRectangle(additionalBrush, new Rectangle(size.Width / 5 * 3 + width / 4 * 3, startY, width / 4, height));
                g.DrawLine(additionalPen, new Point(size.Width / 5 * 3 + width / 4 * 3, startY),
                    new Point(size.Width / 5 * 3 + width / 4 * 3, startY + height));
                break;
            case Stack.StackOperation.Push2:
                g.DrawBezier(penArrow, new Point(size.Width / 5 * 4 + width / 4, startY - height / 3 + 5),
                    new Point(size.Width / 5 * 4 + width, startY - height / 4),
                    new Point(size.Width / 5 * 4 + width, startY + height / 4),
                    new Point(size.Width / 5 * 3 + width, startY + height / 2)
                    );
                goto case Stack.StackOperation.Push1;
            case Stack.StackOperation.Push3:
                g.DrawRectangle(pen, new Rectangle(size.Width / 5 * 3, startY, width, height));
                g.FillRectangle(backBrush, new Rectangle(size.Width / 5 * 3, startY, width, height));
                g.FillRectangle(additionalBrush, new Rectangle(size.Width / 5 * 3 + width / 4 * 3, startY, width / 4, height));
                g.DrawLine(additionalPen, new Point(size.Width / 5 * 3 + width / 4 * 3, startY),
                    new Point(size.Width / 5 * 3 + width / 4 * 3, startY + height));
                g.DrawString(state._current[0].ToString(), font, brush, new PointF(size.Width / 5 * 3 + width / 5, startY + height / 8));
                break;
            case Stack.StackOperation.Push4:
                g.DrawLine(penArrow, new Point(size.Width / 5 * 3, startY + height / 2),
                    new Point(startX + width / 2, startY + height + betweenSize));
                goto case Stack.StackOperation.Push3;
            case Stack.StackOperation.Push5:
                if (state._current.Count > 0)
                {
                    int? a = state._current[0];
                    g.DrawRectangle(pen, new Rectangle(startX, startY + height + betweenSize, width, height));
                    g.FillRectangle(backBrush, new Rectangle(startX, startY + height + betweenSize, width, height));
                    g.DrawString(state._current[0].ToString(), font, brush, new PointF(startX + width / 5,
                        startY + height + betweenSize + height / 5));
                    g.FillRectangle(additionalBrush,
                        new Rectangle(startX + width / 4 * 3, startY + height + betweenSize, width / 4, height));
                    g.DrawLine(pen, new Point(startX + width / 4 * 3, startY + height + betweenSize),
                        new Point(startX + width / 4 * 3, startY + height + betweenSize + height));
                    if (state._current.Count > 1)
                    {
                        g.DrawLine(penArrow,
                            new Point(startX + width - 15, startY + height + betweenSize + height / 2),
                            new Point(startX + width + betweenSize, startY + height + betweenSize + height / 2));
                    }
                    else
                    {
                        g.DrawLine(additionalPen,
                            new Point(startX + width / 4 * 3, startY + height + betweenSize),
                            new Point(startX + width, startY + height + betweenSize + height));
                    }
                }
        // теперь это история => //сюда мы просто заходим когда берём нулевой в пустом списке, а мне лень нёрфить это по-другому
                break;
            case Stack.StackOperation.Pop1:
                goto case Stack.StackOperation.Push5;
            case Stack.StackOperation.Pop2:
                if (state._current.Count > 0)
                {
                    int? a = state._current[0];
                    g.DrawRectangle(pen, new Rectangle(startX, startY + height + betweenSize, width, height));
                    g.FillRectangle(backBrush, new Rectangle(startX, startY + height + betweenSize, width, height));
                    g.DrawString(state._current[0].ToString(), font, brush, new PointF(startX + width / 5,
                        startY + height + betweenSize + height / 5));
                    g.FillRectangle(additionalBrush,
                        new Rectangle(startX + width / 4 * 3, startY + height + betweenSize, width / 4, height));
                    g.DrawLine(pen, new Point(startX + width / 4 * 3, startY + height + betweenSize),
                        new Point(startX + width / 4 * 3, startY + height + betweenSize + height));
                }
                break;
            case Stack.StackOperation.Pop3:
                goto case Stack.StackOperation.Push5;
            case Stack.StackOperation.Peek:
                goto case Stack.StackOperation.Push5;
            case Stack.StackOperation.IsEmpty:
                goto case Stack.StackOperation.Push5;
        }
    }
}