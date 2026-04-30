using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            // 색상콤보박스이벤트연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0;  // 기본값: Black
                                         // 선두께트랙바이벤트연결
            trbLineWidth.Minimum = 1;    // 최소값
            trbLineWidth.Maximum = 10;   // 최대값
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            picCanvas.MouseWheel += new MouseEventHandler(Form1_MouseWheel);


        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
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
            if (!isDrawing) return;
            // 점선펜(미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = new Point((int)(e.X / zoomScale), (int)(e.Y / zoomScale));
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            endPoint = new Point((int)(e.X / zoomScale), (int)(e.Y / zoomScale));
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            endPoint = new Point((int)(e.X / zoomScale), (int)(e.Y / zoomScale));

            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate();
        }

        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
            );
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // 1. 파일 저장을 위한 대화상자 설정
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // 저장할 수 있는 파일 형식 필터 설정
                saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "그림 저장";
                saveFileDialog.FileName = "test"; // 기본 파일명 설정

                // 2. 사용자가 '저장' 버튼을 눌렀을 때만 실행
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 선택한 파일 이름 가져오기
                    string fileName = saveFileDialog.FileName;

                    // 3. 파일 확장자에 맞춰 포맷 지정 및 저장
                    if (fileName.EndsWith(".png"))
                        canvasBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                    else if (fileName.EndsWith(".jpg"))
                        canvasBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (fileName.EndsWith(".bmp"))
                        canvasBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);

                    MessageBox.Show("저장이 완료되었습니다.");
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일|*.png;*.jpg;*.jpeg;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 외부 이미지 로드 [cite: 203]
                    Image loadedImage = Image.FromFile(openFileDialog.FileName);

                    // 이미지 크기에 맞는 새 비트맵 생성 및 캔버스 교체 [cite: 201]
                    canvasBitmap = new Bitmap(loadedImage);
                    canvasGraphics = Graphics.FromImage(canvasBitmap);

                    // PictureBox 업데이트 및 크기 조정 
                    picCanvas.Image = canvasBitmap;
                    picCanvas.SizeMode = PictureBoxSizeMode.AutoSize; // 이미지 크기에 맞춤

                    loadedImage.Dispose();
                    picCanvas.Invalidate();
                }
            }
        }
        // 현재 확대 배율 (1.0 = 100%)
        private double zoomScale = 1.0;

        // 확대/축소 실행 함수
        private void ApplyZoom(double scale)
        {
            zoomScale = scale;

            if (canvasBitmap != null)
            {
                // 1. 이미지의 원본 크기에 배율을 곱하여 PictureBox 크기 설정
                picCanvas.Width = (int)(canvasBitmap.Width * zoomScale);
                picCanvas.Height = (int)(canvasBitmap.Height * zoomScale);

                // 2. PictureBox의 SizeMode를 Zoom으로 설정하여 크기에 맞게 이미지가 늘어나도록 함
                picCanvas.SizeMode = PictureBoxSizeMode.Zoom;

                // 3. 부모 패널의 스크롤바 갱신
                picCanvas.Invalidate();
            }
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // 마우스 휠을 위로 돌리면 Delta가 양수(+)가 됩니다.
            // Control 키가 눌려있는지 확인하는 알고리즘
            if (ModifierKeys == Keys.Control)
            {
                // 휠을 위로 돌리면 확대, 아래로 돌리면 축소
                if (e.Delta > 0)
                {
                    ApplyZoom(zoomScale + 0.1); // 10% 확대
                }
                else
                {
                    if (zoomScale > 0.2) // 최소 배율 제한
                    {
                        ApplyZoom(zoomScale - 0.1); // 10% 축소
                    }
                }
                // 스크롤 이벤트가 픽처박스나 패널로 전달되지 않도록 처리 (선택 사항)
                // HandledMouseEventArgs를 사용하면 스크롤 방지가 가능합니다.
                if (e is HandledMouseEventArgs hme)
                {
                    hme.Handled = true;
                }
            }
        }
    }
}
