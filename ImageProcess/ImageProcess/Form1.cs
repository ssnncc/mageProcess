using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class bieudo : Form
    {
        Bitmap img;
        public bieudo()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //Đọc ảnh vào Bimap
            OpenFileDialog opent = new OpenFileDialog();
            opent.InitialDirectory = @"C:\Users\VU VU\Pictures\Saved Pictures";
            if (opent.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img = new Bitmap(opent.FileName);
                pictureBox1.Image = img;
            }
        }

        unsafe
        private Bitmap AnhXam(Bitmap img)
        {
            Bitmap imgtmp = img;
            //Nạp ảnh vào bitmapdata
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite,
                                                imgtmp.PixelFormat);
            //Tính offset
            int offset = imgdata.Stride - imgtmp.Width * 3;//Số bye Mà máy tính lưu trữ mỗi hàng của máy tính
            //Truy cập đến con trỏ đầu tiên
            byte* p = (byte*)imgdata.Scan0;//Địa chỉ byte đầu tiên của ảnh mà vùng imgdata quan lý
            //Duyệt ảnh
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    //Xử lý 3 byte của 1 pixel
                    int t = (p[0] + p[1] + p[2]) / 3;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    //Chuyển con trỏ sang byte kế tiếp
                    p = p + 3;
                }
                p = p + offset;//Chuyển xuống hàng kế tiếp
            }
            //Giải phóng biến BitmapData
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }

        private void Anhxam_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                pictureBox2.Image = AnhXam(img);

            }

        }
        unsafe
        private Bitmap AnhNhiPhan(Bitmap img, byte Nguong)
        {
            Bitmap imgtmp = img;
            //Nạp ảnh vào bitmapdata
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite,
                                                imgtmp.PixelFormat);
            //Tính offset
            int offset = imgdata.Stride - imgtmp.Width * 3;//Số bye Mà máy tính lưu trữ mỗi hàng của máy tính
            //Truy cập đến con trỏ đầu tiên
            byte* p = (byte*)imgdata.Scan0;//Địa chỉ byte đầu tiên của ảnh mà vùng imgdata quan lý
            //Duyệt ảnh
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    //Xử lý 3 byte của 1 pixel
                    int t = (p[0] + p[1] + p[2]) / 3;
                    if((byte)t< Nguong)
                    {
                        t = 0;
                    }
                    else
                    {
                        t = 255;
                    }
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    //Chuyển con trỏ sang byte kế tiếp
                    p = p + 3;
                }
                p = p + offset;//Chuyển xuống hàng kế tiếp
            }
            //Giải phóng biến BitmapData
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }

        private void NhiPhan_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                pictureBox2.Image = AnhNhiPhan(img, 100);//cho ngưỡng =100
            }
        }
        unsafe
        private Bitmap AnhAmBan(Bitmap img)
        {
            Bitmap imgtmp = img;
            //Nạp ảnh vào bitmapdata
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite,
                                                imgtmp.PixelFormat);
            //Tính offset
            int offset = imgdata.Stride - imgtmp.Width * 3;//Số bye Mà máy tính lưu trữ mỗi hàng của máy tính
            //Truy cập đến con trỏ đầu tiên
            byte* p = (byte*)imgdata.Scan0;//Địa chỉ byte đầu tiên của ảnh mà vùng imgdata quan lý
            //Duyệt ảnh
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    //Xử lý 3 byte của 1 pixel
                    int t = (p[0] + p[1] + p[2]) / 3;
                    t = 255 - t;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    //Chuyển con trỏ sang byte kế tiếp
                    p = p + 3;
                }
                p = p + offset;//Chuyển xuống hàng kế tiếp
            }
            //Giải phóng biến BitmapData
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }

        private void Amban_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                pictureBox2.Image = AnhAmBan(img);
            }
        }
        public static bool LocTrungVi(Bitmap img)
        {
            //Loc trung vi
            Bitmap imgtmp = (Bitmap)img.Clone();
            BitmapData imgdata = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format24bppRgb);
            BitmapData imgtmpdata = imgtmp.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format24bppRgb);
            int stride = imgdata.Stride;
            int stride2 = stride * 2;
            ArrayList list;
            unsafe
            {
                byte* p = (byte*)imgdata.Scan0;
                byte* p1 = (byte*)imgtmpdata.Scan0;
                int nOffset = stride - img.Width * 3;
                int nWidth = img.Width - 2;
                //trừ đi các rìa ảnh
                int nHeight = img.Height - 2;
                int nPixel;
                list = new ArrayList();
                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        for (int i = 0; i < 3; ++i)
                        {
                            list.Add(p1[0]);
                            list.Add(p1[3]);
                            list.Add(p1[6]);
                            list.Add(p1[0 + stride]);
                            list.Add(p1[3 + stride]);
                            list.Add(p1[6 + stride]);
                            list.Add(p1[0 + stride2]);
                            list.Add(p1[3 + stride2]);
                            list.Add(p1[6 + stride2]);
                            list.Sort();
                            nPixel = Convert.ToInt32(list[4]);
                            if (nPixel < 0) nPixel = 0;
                            if (nPixel > 255) nPixel = 255;
                            p[3 + stride] = (byte)nPixel;
                            ++p;
                            ++p1;
                            list.Clear();
                        }
                    }
                    p += nOffset;
                    p1 += nOffset;
                }
            }
            img.UnlockBits(imgdata);
            return true;
        }

        private void Locnhieu_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                if (LocTrungVi(img))
                {
                    pictureBox2.Image = img;
                }
            }
        }
        public static bool Sobel(Bitmap img)
        {
            int[] matrix = new int[9];
            int[,] pixelPicture = new int[img.Width - 2, img.Height - 2];
            int[,] pixelPicture1 = new int[img.Width - 2, img.Height - 2];
            int[,] pixelPicture2 = new int[img.Width - 2, img.Height - 2];
            int pixel;
            int count = 0;
            for (int i = 0; i < img.Width - 2; i++)
                for (int j = 0; j < img.Height - 2; j++)
                {
                    count = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color color = img.GetPixel(n, m);
                            matrix[count] = color.R;
                            count++;
                        }
                    pixel = matrix[0] * -1 + matrix[1] * -2 + matrix[3] * -1 + matrix[6] * 1 + matrix[7] * 2 + matrix[8] * 1;
                    pixelPicture1[i, j] = pixel;

                }
            for (int i = 0; i < img.Width - 2; i++)
                for (int j = 0; j < img.Height - 2; j++)
                {
                    count = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color color = img.GetPixel(n, m);
                            matrix[count] = color.R;
                            count++;
                        }
                    pixel = matrix[0] * -1 + matrix[2] * 1 + matrix[3] * -2 + matrix[5] * 2 + matrix[6] * -1 + matrix[8] * 1;
                    pixelPicture2[i, j] = pixel;

                }
            for (int i = 0; i < img.Width - 2; i++)
                for (int j = 0; j < img.Height - 2; j++)
                {
                    pixelPicture[i, j] = Math.Abs(pixelPicture1[i, j]) + Math.Abs(pixelPicture2[i, j]);
                }
            for (int i = 0; i < img.Width - 2; i++)
                for (int j = 0; j < img.Height - 2; j++)
                {
                    Color color = img.GetPixel(i, j);
                    if (pixelPicture[i, j] > 255)
                        img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    else
                        img.SetPixel(i, j, Color.FromArgb(pixelPicture[i, j], pixelPicture[i, j], pixelPicture[i, j]));
                }
            return true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dobien_Click_1(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                if (Sobel(img))
                {
                    pictureBox2.Image = img;
                }
            }

        }

        //Tạo Histogram
        public static bool HienThiHistogram(Bitmap img, Bitmap histogram)
        {
            // Biến lưu tất cả giá trị điểm ảnh ban đầu
            int[] pixelValue = new int[img.Width * img.Height];
            // Biến đếm
            int count = 0;
            // Vòng lặp lấy ra giá trị của tất cả điểm ảnh ban đầu
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    pixelValue[count] = color.R;
                    count++;
                }

            // Biến lưu số lượng các mức xám từ 0-255
            int[] grayValue = new int[256];
            // Reset biến đếm
            count = 0;
            // Vòng lặp đếm số lượng các mức xám
            for (int i = 0; i <= 255; i++)
            {
                for (int j = 0; j < img.Height * img.Width; j++)
                    if (i == pixelValue[j])
                        count++;
                grayValue[i] = count;
                count = 0;
            }

            // Tìm ra điểm sáng max và chia tỉ lệ để hiển thị Histogram
            int max = grayValue[0];
            for (int i = 1; i <= 255; i++)
                if (grayValue[i] > max)
                    max = grayValue[i];
            // Chia tỉ lệ
            float ratio = histogram.Height / (float)max;
            // Điều chỉnh lại tỉ lệ hiển thị
            for (int i = 0; i <= 255; i++)
                grayValue[i] = Convert.ToInt32(grayValue[i] * ratio);

            // Hiển thị Histogram
            // Quét màu đen
            for (int i = 0; i < histogram.Width; i++)
                for (int j = 0; j < histogram.Height; j++)
                    histogram.SetPixel(i, j, Color.FromArgb(240, 240, 240));
            // Quét điểm ảnh để hiển thị
            for (int i = 0; i < histogram.Width; i++)
                for (int j = 0; j < histogram.Height; j++)
                {
                    if (j >= (histogram.Height - grayValue[i]) && j < histogram.Height)
                        histogram.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }

            return true;
        }

        public static bool CanBangHistogram(Bitmap img, Bitmap histogram)
        {
            // Biến lưu tất cả giá trị điểm ảnh ban đầu
            int[] pixelValue = new int[img.Width * img.Height];
            // Biến đếm
            int count = 0;
            // Vòng lặp lấy ra giá trị của tất cả điểm ảnh ban đầu
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    pixelValue[count] = color.R;
                    count++;
                }

            // Biến lưu số lượng các mức xám từ 0-255
            int[] grayValue = new int[256];
            // Reset biến đếm
            count = 0;
            // Vòng lặp đếm số lượng các mức xám
            for (int i = 0; i <= 255; i++)
            {
                for (int j = 0; j < img.Height * img.Width; j++)
                    if (i == pixelValue[j])
                        count++;
                grayValue[i] = count;
                count = 0;
            }

            // Tìm ra độ sáng thấp nhất tổng giá trị sáng
            int min = grayValue[0];
            int allValue = 0;
            for (int i = 0; i <= 255; i++)
            {
                allValue += grayValue[i];
                if (grayValue[i] < min)
                    min = grayValue[i];
            }


            // Chuyển hết mức xám về giá trị mới
            // Biến cộng dồn
            int increment = 0;
            for (int i = 0; i <= 255; i++)
            {
                //System.Console.WriteLine(allValue);
                increment += grayValue[i];
                double num = (double)(increment - min) / (allValue - 1);
                //System.Console.WriteLine(num);
                grayValue[i] = (int)Math.Round(num * 255);
                //System.Console.WriteLine(grayValue[i]);
            }

            // Đặt lại ảnh xám
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    int value = color.R;
                    img.SetPixel(i, j, Color.FromArgb(grayValue[value], grayValue[value], grayValue[value]));
                }

            return true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Htg_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(this.pictureBox1.Image);
            AnhAmBan(img);
            Bitmap his = new Bitmap(256, 60);
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                if (HienThiHistogram(img, his))
                {
                    pictureBox3.Image = his;
                }
            }
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(this.pictureBox1.Image);
            AnhXam(img);
            Bitmap his = new Bitmap(256, 60);
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                if (HienThiHistogram(img, his))
                {
                    CanBangHistogram(img, his);
                    HienThiHistogram(img, his);
                    pictureBox2.Image = img;
                    pictureBox3.Image = his;
                }
            }
            
        }

        unsafe
        private Bitmap BienDoiLog(Bitmap img)
        {
            Bitmap imgtmp = new Bitmap(img.Width, img.Height);
            imgtmp = img;
            BitmapData imgdata = imgtmp.LockBits(new Rectangle(0, 0, imgtmp.Width, imgtmp.Height), ImageLockMode.ReadWrite, imgtmp.PixelFormat);
            int offset = imgdata.Stride - 3 * imgtmp.Width;

            byte* p = (byte*)imgdata.Scan0;
            for (int i = 0; i < imgtmp.Height; i++)
            {
                for (int j = 0; j < imgtmp.Width; j++)
                {
                    int t = (p[0] + p[1] + p[2]) / 3;
                    t = (byte)Math.Log(1 + t);
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;

                    p += 3;
                }
                p += offset;
            }
            imgtmp.UnlockBits(imgdata);
            return imgtmp;
        }

        //Lưu hình ảnh lại
        private void Luu_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Ảnh chưa đựơc xử lý!", "Image Null");
            }
            else
            {
                SaveFileDialog saveimg = new SaveFileDialog();
                saveimg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveimg.Title = "Save an Image File";
                saveimg.InitialDirectory = @"C:\Users\VU VU\Pictures\Saved Pictures";

                if (saveimg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(saveimg.FileName);
                    MessageBox.Show("Ảnh đã được lưu!", "Save Image");
                }
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Chưa có ảnh đầu vào!!!", "Image Null");
            }
            else
            {
                pictureBox2.Image = BienDoiLog(img);
            }
        }
    }
}
