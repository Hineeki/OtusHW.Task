using System.Net;
using System.Threading.Channels;

namespace ClassLibrary

{
    public class ImageDownloader
    {
        string remoteUri = "https://www.nasa.gov/sites/default/files/thumbnails/image/main_image_star-forming_region_carina_nircam_final-5mb.jpg";
        string fileName = "bigimage.jpg";

        public delegate void DownloadHendler();
        public event Action DownloadStarted;
        public event DownloadHendler? DownloadFinished;

        public async Task Download()
        {
            WebClient myWebClient = new WebClient();
            DownloadStarted.Invoke();
            myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
            DownloadFinished?.Invoke();
        }
    }
}