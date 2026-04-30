using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }  // 사용할도형타입
        private Bitmap canvasBitmap;          // 실제그림이저장되는비트맵
        private Graphics canvasGraphics;      // 비트맵위에그리기위한객체
        private bool isDrawing = false;       // 현재드래그중인지여부
        private Point startPoint;             // 드래그시작점
        private Point endPoint;               // 드래그끝점
        private ToolType currentTool = ToolType.Line;  // 현재선택된도형
        private Color currentColor = Color.Black;      // 현재색상
        private int currentLineWidth = 2;              // 현재선두께


        public Form1()
        {
            InitializeComponent();
            // 캔버스초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);   // 캔버스를흰색으로초기화
            picCanvas.Image = canvasBitmap;   // 그린그림을화면(PictureBox)에표시
                                              // 마우스이벤트연
            // picCanvas가다시그려질때PicCanvas_Paint함수를실행하도록연결
            picCanvas.Paint += PicCanvas_Paint;
            // 도형선택버튼이벤트연결
            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;


        }

        private void btnLine_Click(object sender, EventArgs e)
        {

        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedIndex(선택된 순서)를 이용한 조건문 알고리즘
            switch (cmbColor.SelectedIndex)
            {
                case 0: // 첫 번째 항목 (Black)
                    currentColor = Color.Black;
                    break;
                case 1: // 두 번째 항목 (Red)
                    currentColor = Color.Red;
                    break;
                case 2: // 세 번째 항목 (Blue)
                    currentColor = Color.Blue;
                    break;
                case 3: // 네 번째 항목 (Green)
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
