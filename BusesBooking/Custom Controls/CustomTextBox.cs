using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBusesBooking.Custom_Controls
{
    public partial class CustomTextBox : Control
    {
        private TextBox textBox1;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        public CustomTextBox()
        {
            // Initialize the TextBox within the custom control
            textBox1 = new TextBox();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(7, 7);
            textBox1.Size = new Size(236, 15);
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.Click += TextBox1_Click;
            textBox1.MouseEnter += TextBox1_MouseEnter;
            textBox1.MouseLeave += TextBox1_MouseLeave;
            textBox1.KeyPress += TextBox1_KeyPress;

            this.Controls.Add(textBox1);  // Add TextBox to Custom Control

            // Customize the default size
            this.Padding = new Padding(7);
            this.Size = new Size(250, 30);
            this.BackColor = SystemColors.Window;
            this.ForeColor = Color.DimGray;
            InitializeComponent();
        }

        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        // Properties
        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        // Override OnPaint to customize the border appearance
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            // رسم الحدود باستخدام Pen
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                // إذا كان في فوكس نغير اللون
                if (isFocused)
                    penBorder.Color = borderFocusColor;

                // رسم الحدود العلوية إذا كانت غير مفعلة `underlinedStyle`
                if (!underlinedStyle)
                {
                    // رسم الحدود العلوية (Top)
                    graph.DrawLine(penBorder, 0, 0, this.Width, 0);

                    // رسم الحدود اليسرى (Left)
                    graph.DrawLine(penBorder, 0, 0, 0, this.Height);

                    // رسم الحدود اليمنى (Right)
                    graph.DrawLine(penBorder, this.Width - 1, 0, this.Width - 1, this.Height);

                    // رسم الحدود السفلية (Bottom)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    // رسم الحدود السفلية فقط (Bottom) عند تفعيل `underlinedStyle`
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
            }
        }


        // Handle focus state
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        // TextBox TextChanged event
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        public event EventHandler _TextChanged;

        // Additional events like click and mouse events
        bool firstClick = true;
        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                textBox1.Text = "";
                firstClick = false;
            }
            this.OnClick(e);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
