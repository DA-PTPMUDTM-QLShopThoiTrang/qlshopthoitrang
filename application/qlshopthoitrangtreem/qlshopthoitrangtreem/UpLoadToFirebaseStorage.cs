using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Firebase.Storage;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using SkiaSharp;

namespace qlshopthoitrangtreem
{
    public class UpLoadToFirebaseStorage
    {
        private string Bucket = "fashion-app-84f9f.appspot.com";

        public UpLoadToFirebaseStorage() { }
        private async Task<string> GetDataFromUrl(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private string ExtractDownloadTokens(string jsonResponse)
        {
            JObject json = JObject.Parse(jsonResponse);
            return json["downloadTokens"]?.ToString();
        }
        private async Task<Stream> DownloadImageAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStreamAsync();
            }
        }
        public async Task<Bitmap> LoadImageFromUrl(string imageUrl)
        {
            try
            {
                Bitmap thumbnailBitmap;
                using (var stream = await DownloadImageAsync(imageUrl))
                {
                    using (var bitmap = SKBitmap.Decode(stream))
                    {
                        using (var image = SKImage.FromBitmap(bitmap))
                        {
                            using (var imageStream = image.Encode(SKEncodedImageFormat.Png, 100).AsStream())
                            {
                                thumbnailBitmap = CreateThumbnail(new Bitmap(imageStream, false), 100, 100); // Tạo thumbnail với kích thước 100x100
                            }
                        }
                    }
                }
                return thumbnailBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return await this.LoadImageFromUrl("https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/receipts%2Ftest%2Forange-error-icon-0.png?alt=media&token=ace9b505-9834-44c1-8098-23583dcede0e");
            }
            return null;
        }
        private Bitmap CreateThumbnail(Bitmap original, int width, int height)
        {
            Bitmap thumbnail = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(thumbnail))
            {
                try
                {
                    g.DrawImage(original, 0, 0, width, height);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return thumbnail;
        }
        /*private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";
                        progressBar1.Value += 10;
                        var stream = File.Open(openFileDialog.FileName, FileMode.Open);
                        var cancellation = new CancellationTokenSource();
                        var task = new FirebaseStorage(
                        Bucket,
                        new FirebaseStorageOptions
                        {
                            ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                        })
                        .Child("qlthoitrangtreemimg")
                        .Child(openFileDialog.SafeFileName).PutAsync(stream, cancellation.Token);
                        try
                        {
                            await task;
                            string responseContent = await GetDataFromUrl(task.TargetUrl);
                            string downloadTokens = ExtractDownloadTokens(responseContent);
                            string urlImage = task.TargetUrl + "&alt=media&token=" + downloadTokens;
                            await LoadImageFromUrl(urlImage);
                            progressBar1.Value = 100;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception was thrown: {0}", ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }*/
        public async Task<string> uploadImage(Stream stream, string filename)
        {
            var cancellation = new CancellationTokenSource();
            var task = new FirebaseStorage(
            Bucket,
            new FirebaseStorageOptions
            {
                ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                        })
            .Child("qlthoitrangtreemimg")
            .Child(filename).PutAsync(stream, cancellation.Token);
            try
            {
                await task;
                string responseContent = await GetDataFromUrl(task.TargetUrl);
                string downloadTokens = ExtractDownloadTokens(responseContent);
                string urlImage = task.TargetUrl + "&alt=media&token=" + downloadTokens;
                return urlImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception was thrown: {0}", ex);
            }
            return null;
        }
    }
}
