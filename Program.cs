// See https://aka.ms/new-console-template for more information
using System.Drawing.Imaging;

var sleep = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;
var tempPath = Path.GetTempPath();
while (true)
{
    var image = ScreenCapture.CaptureDesktop();

    var fileName = $@"{tempPath}\{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.jpg";
    image.Save(fileName, ImageFormat.Jpeg);
    Console.WriteLine(fileName);
    Thread.Sleep(sleep);
}

