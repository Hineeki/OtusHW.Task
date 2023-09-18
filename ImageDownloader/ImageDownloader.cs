using System.Net;
using System.Threading.Channels;

namespace MyLibrary

{
    public class ImageDownloader
    {
        string remoteUri = @"https://stsci-opo.org/STScI-01G5PGR10JASH299DZBV7S15CX.png";
        string fileName = "bigimage.png";

        public delegate void DownloadHendler();
        public event Action? DownloadStarted;
        public event DownloadHendler? DownloadFinished;

        public async Task Download()
        {
            WebClient myWebClient = new WebClient();
            DownloadStarted.Invoke();
            await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
            DownloadFinished?.Invoke();
        }
    }
}