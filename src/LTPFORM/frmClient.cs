using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class frmClient : Form
    {
        public static class GlobalVariables
        {
            public static int ketnoi = 0; // Biến toàn cục chia sẻ giữa các form
        }

        public frmClient()
        {
            InitializeComponent();
        }
        private void btnYoutube_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.ketnoi == 1 )
            {
                // Kiểm tra xem form đã được mở chưa, nếu có thì đóng trước
                pnMain.Controls.Clear(); // Xóa nội dung cũ

                frmTaiNhac uc = new frmTaiNhac(); // Tạo Form
                uc.TopLevel = false; // QUAN TRỌNG: Đặt Form thành không phải cửa sổ chính
                uc.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
                uc.Dock = DockStyle.Fill; // Phủ toàn bộ Panel

                pnMain.Controls.Add(uc); // Thêm vào Panel
                uc.Show(); // Hiển thị Form
            }
            else
            {
                MessageBox.Show("Bạn hiện đang không kết nối" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LoadFormInPanel(Form frm)
        {
            pnMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frm);
            frm.Show();
        }
        private void frmClient_Load(object sender, EventArgs e)
        {
            KiemTraMang();
            timerCheckInternet.Interval = 1000; // 10s
            timerCheckInternet.Start();
            LoadFormInPanel(new frmAbout());
        }
        private void timerCheckInternet_Tick(object sender, EventArgs e)
        {
            KiemTraMang();
        }
        private void KiemTraMang()
        {
            picIcon.Size = new Size(32, 32);

            // Đặt chế độ hiển thị ảnh
            picIcon.SizeMode = PictureBoxSizeMode.Zoom; // Hoặc StretchImage

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");

                if (reply.Status == IPStatus.Success)
                {
                    GlobalVariables.ketnoi = 1;// kết nối 
                    lblTrangThai.Text = "✅ Đã kết nối mạng";
                    //lblTrangThai.ForeColor = Color.Green;
                    picIcon.Image = Properties.Resources.icon_success; // icon xanh
                }
                else
                {
                    GlobalVariables.ketnoi = 0;//mất kết nối 
                    lblTrangThai.Text = "❌ Mất kết nối mạng";
                    //lblTrangThai.ForeColor = Color.Red;
                    picIcon.Image = Properties.Resources.icon_error; // icon đỏ

                }
            }
            catch
            {
                GlobalVariables.ketnoi = 0;//mất kết nối 
                lblTrangThai.Text = "⚠️ Không kiểm tra được!";
                //lblTrangThai.ForeColor = Color.Orange;
                picIcon.Image = Properties.Resources.icon_warning; // icon vàng

            }
        }

        private void timerCheckInternet_Tick_1(object sender, EventArgs e)
        {
            KiemTraMang();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.ketnoi == 1)
            {
                // Kiểm tra xem form đã được mở chưa, nếu có thì đóng trước
                pnMain.Controls.Clear(); // Xóa nội dung cũ

                frmWindow uc = new frmWindow(); // Tạo Form
                uc.TopLevel = false; // QUAN TRỌNG: Đặt Form thành không phải cửa sổ chính
                uc.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
                uc.Dock = DockStyle.Fill; // Phủ toàn bộ Panel

                pnMain.Controls.Add(uc); // Thêm vào Panel
                uc.Show(); // Hiển thị Form
            }
            else
            {
                MessageBox.Show("Bạn hiện đang không kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new frmAbout());


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
