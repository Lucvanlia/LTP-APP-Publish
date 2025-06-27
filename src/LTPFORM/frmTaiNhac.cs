using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using static WindowsFormsApp1.frmClient;
namespace WindowsFormsApp1
{
    public partial class frmTaiNhac : Form
    {   

        public frmTaiNhac()
        {
            InitializeComponent();
            Directory.CreateDirectory(outputFolder);

        }

        private YoutubeClient youtube = new YoutubeClient();
        private string ytDlpPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yt-dlp.exe");
        private string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
        private string outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string GetVideoIdFromUrl(string url)
        {
            var match = Regex.Match(url, @"(?:youtube\.com\/(?:[^\/]+\/.+\/|(?:v|e(?:mbed)?)\/|.*[?&]v=)|youtu\.be\/)([^\""&?\/\s]{11})");
            return match.Success ? match.Groups[1].Value : null;
        }
        private void frmTaiNhac_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.ketnoi == 1)
            {
                // Cho phép tải nhạc nếu ketnoi == 0
                txtUrl.Enabled = true;
                btnTai.Enabled = true;
            }
            else
            {
                // Nếu ketnoi != 0, không cho phép tải nhạc
                txtUrl.Enabled = false;
                btnTai.Enabled = false;
                MessageBox.Show("Không thể tải nhạc, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string GetUniqueFileName(string savePath, string fileName, string extension)
        {
            string newFileName = fileName;
            string fullPath = Path.Combine(savePath, newFileName + extension);
            int counter = 1;

            while (File.Exists(fullPath)) // Nếu file đã tồn tại, thêm số vào cuối
            {
                newFileName = $"{fileName}_{counter}";
                fullPath = Path.Combine(savePath, newFileName + extension);
                counter++;
            }

            return fullPath; // Trả về đường dẫn đầy đủ thay vì chỉ tên file
        }
        private async  void btnLink_Click(object sender, EventArgs e)
        {
            string youtubeUrl = txtLink.Text.Trim();
            string videoId = GetVideoIdFromUrl(youtubeUrl);
            if (string.IsNullOrEmpty(videoId))
            {
                MessageBox.Show("Vui lòng nhập link YouTube hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var video = await youtube.Videos.GetAsync(youtubeUrl);
                lblTenVideo.Text = video.Title;
                pnTaiXuong.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy video hoặc link sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtUrl.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void btnTai_Click(object sender, EventArgs e)
        {
            string youtubeUrl = txtLink.Text.Trim();
            string fileName = txtTenFile.Text.Trim();
            string savePath = txtUrl.Text.Trim();
            txtDowloadFilm.Enabled = false;
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(youtubeUrl) || string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu không nhập tên file, dùng ID video làm tên
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = GetVideoIdFromUrl(youtubeUrl);
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Không thể lấy ID video, vui lòng nhập tên file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            fileName = Regex.Replace(fileName, @"[^a-zA-Z0-9_-]", ""); // Tên file hợp lệ
            string outputFile = "";

            if (!File.Exists(ytDlpPath))
            {
                MessageBox.Show("Không tìm thấy yt-dlp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                progressBar1.Value = 0;

                await Task.Run(() =>
                {
                    // Tải audio (m4a là phổ biến nhất cho audio YouTube)
                    string audioFile = GetUniqueFileName(savePath, fileName, ".m4a");

                    ProcessStartInfo psiDownload = new ProcessStartInfo
                    {
                        FileName = ytDlpPath,
                        Arguments = $"-f bestaudio[ext=m4a]/bestaudio -o \"{audioFile}\" \"{youtubeUrl}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process { StartInfo = psiDownload })
                    {
                        process.Start();
                        process.WaitForExit();
                    }

                    outputFile = audioFile;
                });

                if (File.Exists(outputFile))
                {
                    progressBar1.Value = 100;
                    MessageBox.Show("Tải xong! File lưu tại: " + Path.GetFullPath(outputFile), "Thông báo", MessageBoxButtons.OK);
                    txtDowloadFilm.Enabled = true;
                }
                else
                {
                    txtDowloadFilm.Enabled = true;
                    MessageBox.Show("Tải thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                txtDowloadFilm.Enabled = true;
                MessageBox.Show("Lỗi khi tải: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkM4a_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkMp3_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void txtTenFile_TextChanged(object sender, EventArgs e)
        {
            string tenFile = txtTenFile.Text.Trim();
            string tenFileHopLe = Regex.Replace(tenFile, @"[^a-zA-Z0-9_-]", "");
            if (tenFile != tenFileHopLe) txtTenFile.Text = tenFileHopLe;
        }

        private  void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private async void txtDowloadFilm_Click(object sender, EventArgs e)
        {
            string youtubeUrl = txtLink.Text.Trim();
            string fileName = txtTenFile.Text.Trim();
            string savePath = txtUrl.Text.Trim();
            string ytDlpPath = "yt-dlp.exe"; // Hoặc đường dẫn đầy đủ tới file yt-dlp.exe
            btnTai.Enabled = false;
            // --- Phần kiểm tra đầu vào của bạn (giữ nguyên) ---
            if (string.IsNullOrEmpty(youtubeUrl) || string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(fileName))
            {
                // Bạn có thể thêm hàm GetVideoIdFromUrl nếu muốn, hoặc báo lỗi
                fileName = Guid.NewGuid().ToString(); // Tạo tên ngẫu nhiên nếu không có
            }

            fileName = Regex.Replace(fileName, @"[<>:""/\\|?*]", "_"); // Làm sạch tên file

            if (!File.Exists(ytDlpPath))
            {
                MessageBox.Show("Không tìm thấy file yt-dlp.exe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yêu cầu BẮT BUỘC: ffmpeg phải có để ghép file 4K
            if (!File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("Không tìm thấy file ffmpeg.exe! Cần có ffmpeg để tải video chất lượng cao.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Bắt đầu quá trình tải ---
            progressBar1.Value = 0;
            string finalOutputFile = Path.Combine(savePath, fileName + ".mp4");

            try
            {
                var errorMessages = new StringBuilder();

                await Task.Run(() =>
                {
                    // Cú pháp mới để tải 4K và ghép file
                    string arguments = $"-f bestvideo+bestaudio --merge-output-format mp4 -o \"{finalOutputFile}\" \"{youtubeUrl}\"";

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = ytDlpPath,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.UTF8, // Đảm bảo đọc đúng output
                        StandardErrorEncoding = Encoding.UTF8
                    };

                    using (Process process = new Process { StartInfo = psi })
                    {
                        // Bắt output để lấy % tiến trình
                        process.OutputDataReceived += (s, ev) => {
                            if (ev.Data != null)
                            {
                                // Dùng Regex để tìm % trong output của yt-dlp
                                // Ví dụ output: [download]   5.3% of ~249.26MiB at 12.28MiB/s ETA 00:17
                                Match match = Regex.Match(ev.Data, @"\[download\]\s+([0-9.]+)%");
                                if (match.Success)
                                {
                                    if (double.TryParse(match.Groups[1].Value, out double percentage))
                                    {
                                        // Cập nhật progress bar trên UI thread
                                        progressBar1.Invoke((Action)(() => progressBar1.Value = (int)percentage));
                                    }
                                }
                            }
                        };

                        // Bắt lỗi (nếu có)
                        process.ErrorDataReceived += (s, ev) => {
                            if (ev.Data != null)
                            {
                                errorMessages.AppendLine(ev.Data);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine(); // Bắt đầu đọc output bất đồng bộ
                        process.BeginErrorReadLine();  // Bắt đầu đọc error bất đồng bộ

                        process.WaitForExit(); // Chờ cho đến khi tiến trình kết thúc
                    }
                });

                // --- Kiểm tra kết quả ---
                if (File.Exists(finalOutputFile))
                {
                    progressBar1.Value = 100;
                    btnTai.Enabled = true;
                    MessageBox.Show("Tải xong! File lưu tại: " + finalOutputFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hiển thị lỗi chi tiết từ yt-dlp
                    btnTai.Enabled = true;
                    MessageBox.Show("Tải thất bại!\n\nChi tiết lỗi:\n" + errorMessages.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                btnTai.Enabled = true;
                MessageBox.Show("Đã có lỗi nghiêm trọng xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
