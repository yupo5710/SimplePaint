namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            cmbColor = new ComboBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            gpDiagram = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            gpColor = new GroupBox();
            gpThickness = new GroupBox();
            trbLineWidth = new TrackBar();
            picCanvas = new PictureBox();
            pnlCanvas = new Panel();
            panel2 = new Panel();
            gpDiagram.SuspendLayout();
            gpColor.SuspendLayout();
            gpThickness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(21, 22);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(385, 78);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 초록" });
            cmbColor.Location = new Point(19, 58);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(172, 40);
            cmbColor.TabIndex = 1;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(970, 122);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(160, 86);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(1162, 122);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(160, 86);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // gpDiagram
            // 
            gpDiagram.Controls.Add(btnCircle);
            gpDiagram.Controls.Add(btnRectangle);
            gpDiagram.Controls.Add(btnLine);
            gpDiagram.Location = new Point(21, 103);
            gpDiagram.Name = "gpDiagram";
            gpDiagram.Size = new Size(362, 148);
            gpDiagram.TabIndex = 4;
            gpDiagram.TabStop = false;
            gpDiagram.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(253, 38);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(103, 104);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("맑은 고딕", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(123, 38);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(101, 103);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnLine
            // 
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(0, 38);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(103, 105);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // gpColor
            // 
            gpColor.Controls.Add(cmbColor);
            gpColor.Location = new Point(405, 122);
            gpColor.Name = "gpColor";
            gpColor.Size = new Size(228, 117);
            gpColor.TabIndex = 5;
            gpColor.TabStop = false;
            gpColor.Text = "색 선택";
            // 
            // gpThickness
            // 
            gpThickness.Controls.Add(trbLineWidth);
            gpThickness.Location = new Point(657, 103);
            gpThickness.Name = "gpThickness";
            gpThickness.Size = new Size(289, 140);
            gpThickness.TabIndex = 6;
            gpThickness.TabStop = false;
            gpThickness.Text = "굵기 정도";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(0, 44);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(283, 90);
            trbLineWidth.TabIndex = 0;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.ControlLightLight;
            picCanvas.Location = new Point(17, 10);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1212, 521);
            picCanvas.TabIndex = 7;
            picCanvas.TabStop = false;
            picCanvas.Paint += PicCanvas_Paint;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // pnlCanvas
            // 
            pnlCanvas.AutoScroll = true;
            pnlCanvas.Controls.Add(panel2);
            pnlCanvas.Controls.Add(picCanvas);
            pnlCanvas.Location = new Point(54, 257);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(1232, 542);
            pnlCanvas.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(51, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 800);
            Controls.Add(pnlCanvas);
            Controls.Add(gpThickness);
            Controls.Add(gpColor);
            Controls.Add(gpDiagram);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v.10";
            gpDiagram.ResumeLayout(false);
            gpColor.ResumeLayout(false);
            gpThickness.ResumeLayout(false);
            gpThickness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            pnlCanvas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private ComboBox cmbColor;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private GroupBox gpDiagram;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private GroupBox gpColor;
        private GroupBox gpThickness;
        private TrackBar trbLineWidth;
        private PictureBox picCanvas;
        private Panel pnlCanvas;
        private Panel panel2;
    }
}
