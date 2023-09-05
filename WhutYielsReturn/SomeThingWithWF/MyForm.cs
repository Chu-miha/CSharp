using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeThingWithWF
{
    public partial class MyForm : Form
    {
        // Полe для игры без MVC
        //int size = 5;
        
        TableLayoutPanel table;

        public MyForm(GameModel model)
        {
            InitializeComponent();
            //Диалоговое окно при закрытии
            FormClosing += (sender, eventArgs) =>
            {
                var result = MessageBox.Show("Точно?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) { eventArgs.Cancel = true; }
            };
            #region
            // Добавление текста, ввода текста и кнопки 
            //var label = new Label();
            //label.Text = "Введите число";
            //var label = new Label()
            //{
            //    Text = "Введите число",
            //    Dock = DockStyle.Fill,

            //};
            //Controls.Add(label);

            //var input = new TextBox()
            //{
            //    Dock = DockStyle.Fill,
            //};

            //Controls.Add(input);

            //var button = new Button()
            //{
            //    Text = "Увеличить",
            //};

            //button.Click += (sender, args) =>
            //    {
            //        int number = int.Parse(input.Text);
            //        number++;
            //        input.Text = number.ToString();
            //    };
            //Controls.Add(button);

            //FormBorderStyle = FormBorderStyle.FixedDialog;
            //MaximizeBox = false;

            //резиновый дизайн
            //Load += (sender, args) => OnSizeChanged(EventArgs.Empty);

            //SizeChanged += (sender, args) => 
            //    {
            //        label.Location = new Point(0, 0);
            //        label.Size = new Size(ClientSize.Width, 30);
            //        input.Location = new Point(0, label.Bottom);
            //        input.Size = label.Size;
            //        button.Location = new Point(0, input.Bottom);
            //        button.Size = label.Size;
            //    };

            //Таблица
            //var table = new TableLayoutPanel();
            //table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            //table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            //table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            //table.Controls.Add(new Panel(), 0,0);
            //table.Controls.Add(label, 0, 1);
            //table.Controls.Add(input, 0, 2);
            //table.Controls.Add(button, 0, 3);
            //table.Controls.Add(new Panel(), 0, 4);

            //table.Dock = DockStyle.Fill;

            //Controls.Add(table);


            //DoubleBuffered = true;

            //ClientSize = new Size(600, 600);
            //var centerX = ClientSize.Width / 2;
            //var centerY = ClientSize.Height / 2;
            //var size = 100;
            //var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;

            //var time =  0;
            //var timer = new Timer();
            //timer.Interval = 500;
            //timer.Tick += (sender, args) =>
            //    {
            //        time++;
            //var graphics = CreateGraphics();
            //graphics.TranslateTransform(centerX, centerY);
            //graphics.RotateTransform(time * 360f / 10);
            //graphics.FillEllipse(Brushes.Blue, radius - size / 2, -size / 2, size, size);
            //        Invalidate();
            //    };
            //timer.Start();

            //Paint += (sender, args) =>
            //    {
            //        for (int i = 0; i < time; i++)
            //        {
            //            args.Graphics.TranslateTransform(centerX, centerY);
            //            args.Graphics.RotateTransform(i * 360f / 10);
            //            args.Graphics.FillEllipse(Brushes.Blue, radius - size / 2, -size / 2, size, size);
            //            args.Graphics.ResetTransform();
            //        } 
            //    };
            #endregion

            //Игра 
            table = new TableLayoutPanel { Dock = DockStyle.Fill };
            for (int i = 0;i < model.Size; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / model.Size));
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100f / model.Size));
            }
            for (var column = 0; column < model.Size; column++)
            {
                for (var row = 0; row < model.Size; row++)
                {
                    var button = new Button 
                    {
                        Dock = DockStyle.Fill
                    };
                    var iRow = row;
                    var iColumn = column;
                    // button.Click += MakeMove; без MVC
                    button.Click += (sender, args) => model.MakeMove(iRow, iColumn);
                    table.Controls.Add(button , column, row);
                }
            }
            model.StateChanged += (row, column, state) => table.GetControlFromPosition(column, row).BackColor = state ? Color.Black : Color.White;
            model.Start();
            Controls.Add(table);

        }

        // БЕЗ MVC
        //void Flip (Button buttom)
        //{
        //    buttom.BackColor = buttom.BackColor == Color.White ? Color.Black : Color.White;
        //}

        //void MakeMove(object sender, EventArgs e)
        //{
        //    var position = table.GetCellPosition((Control)sender);
        //    for (int row = 0; row < size; row++)
        //    {
        //        if (row != position.Row)
        //        {
        //            Flip((Button)table.GetControlFromPosition(position.Column, row));
        //        }
        //    }
        //    for (int column = 0; column < size; column++)
        //    {
        //        if (column != position.Column)
        //        {
        //            Flip((Button)table.GetControlFromPosition(column, position.Row));
        //        }
        //    }
        //    Flip((Button)sender);
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    var g = e.Graphics;

        //    g.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
        //    g.RotateTransform(10);
        //    g.ScaleTransform(0.7f, 0.7f);
        //    g.TranslateTransform(-ClientSize.Width / 2, -ClientSize.Height / 2);

        //    g.DrawLine(new Pen(Color.Red, 5), 0, 0, 50, 100);
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //    g.DrawLine(new Pen(Color.Green, 5), 0, 0, 100, 50);

        //    g.FillRectangle(Brushes.Green, 100, 100, 100, 100);

        //    g.DrawString("Опа!!!!", new Font("Arial", 16), Brushes.Red, new Point(0, 250));

        //}

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    var result = MessageBox.Show("Точно?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result != DialogResult.Yes) { e.Cancel = true; }
        //}
    }
}
