using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Face_Regconition
{
	public partial class frmMain : Form
	{
		#region Parameters

		private Capture videoCapture = null;
		private Image<Bgr, Byte> currentFrame = null;
		private Mat frame = new Mat();
		private bool FaceDetectionEnable = false;
		private CascadeClassifier cascadeClassifier = new CascadeClassifier("dataTraining/haarcascade_frontalface_alt2.xml");
		#endregion Parameters

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnCapture_Click(object sender, EventArgs e)
		{
			videoCapture = new Capture();
			videoCapture.ImageGrabbed += ProcessFrame;
			videoCapture.Start();
		}

		private void ProcessFrame(object sender, EventArgs e)
		{
			//Step 1: Video Capture
			videoCapture.Retrieve(frame, 0);
			currentFrame = frame.ToImage<Bgr, Byte>().Resize(picBoxCapture.Width, picBoxCapture.Height, Emgu.CV.CvEnum.Inter.Cubic);
			// Bước 2: nhận diện khuôn mặt
			if (FaceDetectionEnable)
			{
				Mat grayImage = new Mat();
				//conver ảnh màu sang ảnh trắng đen
				CvInvoke.CvtColor(currentFrame, grayImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
				//thuật toán chuẩn hóa lại độ sáng, kết cấu của ảnh 
				CvInvoke.EqualizeHist(grayImage, grayImage);

				Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
				if (rectangles.Length>0)
				{
					foreach (var rectangle in rectangles)
					{
						CvInvoke.Rectangle(currentFrame, rectangle, new Bgr(Color.Red).MCvScalar, 2);
					}
				}
			}

			picBoxCapture.Image = currentFrame.Bitmap;
		}

		private void btnDetectFace_Click(object sender, EventArgs e)
		{
			FaceDetectionEnable = true;
		}
	}
}