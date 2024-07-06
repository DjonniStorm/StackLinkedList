using System.Drawing.Drawing2D;

namespace StackLinkedList;

public partial class FormInformation : Form
{
    public FormInformation()
    {
        InitializeComponent();
        Painter();
    }
    private int CountOperation = 0;
    private void Timer_Tick(object sender, EventArgs args)
    {
        CountOperation = CountOperation > 12 ? 0 : ++CountOperation;
        Painter(CountOperation);
    }
    //да, они лишние, но всё же
    private int value1 = -1;
    private int value2 = -1;
    private int value3 = -1;
    private void Painter(int operation = -1)
    {
        Bitmap bitmap = new(pictureBoxExampleVisualization.Width, pictureBoxExampleVisualization.Height);
        Graphics g = Graphics.FromImage(bitmap);
        Pen pen = new Pen(Color.Black, 5f);
        Pen arrowPen = new Pen(Color.FromArgb(0, 0, 0), 5.2f);
        Pen frontArrowPen = new Pen(Color.BlanchedAlmond, 6f);
        arrowPen.CustomEndCap = new AdjustableArrowCap(5, 5);
        frontArrowPen.CustomEndCap = new AdjustableArrowCap(5, 5);
        Brush backgroundBrush = new SolidBrush(Color.BlanchedAlmond);
        Brush fontBrush = new SolidBrush(Color.Black);

        Random random = new();
        if (CountOperation == 0 || value1 == -1) 
            value1 = (int) random.NextInt64(10, 65);
        if (CountOperation == 0 || value2 == -1)
            value2 = (int) random.NextInt64(10, 65);
        if (CountOperation == 0 || value3 == -1)
            value3 = (int) random.NextInt64(10, 65);

        int maxBottomX = pictureBoxExampleVisualization.Width / 4;
        int maxBottomY = pictureBoxExampleVisualization.Height * 3 / 4;
        int objectWidth = pictureBoxExampleVisualization.Width / 2;
        int objectHeight = pictureBoxExampleVisualization.Height / 5;
        Font font = new Font("Comic Sans MS", objectWidth / 7);
        //дефолтный
        g.DrawRectangle(pen, new Rectangle(maxBottomX, maxBottomY, objectWidth, objectHeight));
        g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX, maxBottomY, objectWidth, objectHeight));
        g.DrawString(value1.ToString(), font, fontBrush, new PointF(maxBottomX + 52, maxBottomY + 18));

        switch(operation)
        {
            case 1: //второй повился
                g.DrawRectangle(pen, new Rectangle(maxBottomX + objectWidth, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX + objectWidth, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.DrawString(value2.ToString(), font, fontBrush, new PointF(maxBottomX + objectWidth + 52, maxBottomY - objectHeight * 2 + 18));
                break;
            case 2: //стрелочка 1
                g.DrawBezier(frontArrowPen, new Point(maxBottomX + objectWidth, maxBottomY - objectHeight * 2 + objectHeight / 2), 
                    new Point(maxBottomX + objectWidth / 4 * 3, maxBottomY - objectHeight * 2 + objectHeight / 5 * 2), 
                    new Point(maxBottomX + objectWidth / 13 * 6, maxBottomY - objectHeight + objectHeight / 13 * 5), 
                    new Point(maxBottomX + objectWidth / 2, maxBottomY));
                g.DrawBezier(arrowPen, new Point(maxBottomX + objectWidth, maxBottomY - objectHeight * 2 + objectHeight / 2), 
                    new Point(maxBottomX + objectWidth / 4 * 3, maxBottomY - objectHeight * 2 + objectHeight / 5 * 2), 
                    new Point(maxBottomX + objectWidth / 13 * 6, maxBottomY - objectHeight + objectHeight / 13 * 5), 
                    new Point(maxBottomX + objectWidth / 2, maxBottomY));
                goto case 1;
            case 3: //2 встал на место
                g.DrawRectangle(pen, new Rectangle(maxBottomX, maxBottomY - objectHeight, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX, maxBottomY - objectHeight, objectWidth, objectHeight));
                g.DrawString(value2.ToString(), font, fontBrush, new PointF(maxBottomX + 52, maxBottomY - objectHeight + 18));
                break;
            case 4: //3 появился
                g.DrawRectangle(pen, new Rectangle(maxBottomX + objectWidth, maxBottomY - objectHeight * 3, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX + objectWidth, maxBottomY - objectHeight * 3, objectWidth, objectHeight));
                g.DrawString(value3.ToString(), font, fontBrush, new PointF(maxBottomX + objectWidth + 52, maxBottomY - objectHeight * 3 + 18));
                goto case 3;
            case 5: //стрелочка 2
                g.DrawBezier(frontArrowPen, new Point(maxBottomX + objectWidth, maxBottomY - objectHeight * 3 + objectHeight / 2),
                    new Point(maxBottomX + objectWidth / 4 * 3, maxBottomY - objectHeight * 3 + objectHeight / 5 * 2),
                    new Point(maxBottomX + objectWidth / 13 * 6, maxBottomY - objectHeight * 2 + objectHeight / 13 * 5),
                    new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight));
                g.DrawBezier(arrowPen, new Point(maxBottomX + objectWidth, maxBottomY - objectHeight * 3 + objectHeight / 2),
                    new Point(maxBottomX + objectWidth / 4 * 3, maxBottomY - objectHeight * 3 + objectHeight / 5 * 2),
                    new Point(maxBottomX + objectWidth / 13 * 6, maxBottomY - objectHeight * 2 + objectHeight / 13 * 5),
                    new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight));
                goto case 4;
            case 6: //3 встал на место
                g.DrawRectangle(pen, new Rectangle(maxBottomX, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.DrawString(value3.ToString(), font, fontBrush, new PointF(maxBottomX + 52, maxBottomY - objectHeight * 2 + 18));
                goto case 3;
            case 7:
                goto case 6;
            case 8: //стрелочка 3
                g.DrawBezier(frontArrowPen, new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight * 2),
                    new Point(maxBottomX + objectWidth / 6 * 3, maxBottomY - objectHeight * 2 - objectHeight  / 3 * 2),
                    new Point(maxBottomX + objectWidth / 6 * 2, maxBottomY - objectHeight * 2 - objectHeight / 2),
                    new Point(maxBottomX, maxBottomY - objectHeight * 3 + objectHeight / 2));
                g.DrawBezier(arrowPen, new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight * 2),
                    new Point(maxBottomX + objectWidth / 6 * 3, maxBottomY - objectHeight * 2 - objectHeight  / 3 * 2),
                    new Point(maxBottomX + objectWidth / 6 * 2, maxBottomY - objectHeight * 2 - objectHeight / 2),
                    new Point(maxBottomX, maxBottomY - objectHeight * 3 + objectHeight / 2));
                goto case 6;
            case 9: //3 ушёл
                g.DrawRectangle(pen, new Rectangle(maxBottomX - objectWidth, maxBottomY - objectHeight * 3, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX - objectWidth, maxBottomY - objectHeight * 3, objectWidth, objectHeight));
                g.DrawString(value3.ToString(), font, fontBrush, new PointF(maxBottomX - objectWidth + 52, maxBottomY - objectHeight * 3 + 18));
                goto case 3;
            case 10:
                goto case 3;
            case 11: //стрелочка 4
                g.DrawBezier(frontArrowPen, new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight), 
                    new Point(maxBottomX + objectWidth / 6 * 3, maxBottomY - objectHeight - objectHeight / 3 * 2), 
                    new Point(maxBottomX + objectWidth / 6 * 2, maxBottomY - objectHeight - objectHeight / 2), 
                    new Point(maxBottomX, maxBottomY - objectHeight * 2 + objectHeight / 2));
                g.DrawBezier(arrowPen, new Point(maxBottomX + objectWidth / 2, maxBottomY - objectHeight), 
                    new Point(maxBottomX + objectWidth / 6 * 3, maxBottomY - objectHeight - objectHeight / 3 * 2), 
                    new Point(maxBottomX + objectWidth / 6 * 2, maxBottomY - objectHeight - objectHeight / 2), 
                    new Point(maxBottomX, maxBottomY - objectHeight * 2 + objectHeight / 2));
                goto case 3;
            case 12:
                g.DrawRectangle(pen, new Rectangle(maxBottomX - objectWidth, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.FillRectangle(backgroundBrush, new Rectangle(maxBottomX - objectWidth, maxBottomY - objectHeight * 2, objectWidth, objectHeight));
                g.DrawString(value2.ToString(), font, fontBrush, new PointF(maxBottomX - objectWidth + 52, maxBottomY - objectHeight * 2 + 18));
                break;
            default:
                break;
        }
        switch(operation)
        {
            case 2:
                labelNowOperation.Text = "Push";
                break;
            case 5:
                labelNowOperation.Text = "Push";
                break;
            case 8:
                labelNowOperation.Text = "Pop";
                break;
            case 11:
                labelNowOperation.Text = "Pop";
                break;
            default:
                labelNowOperation.Text = " ";
                break;
        }
        pictureBoxExampleVisualization.Image = bitmap;
    }

}
