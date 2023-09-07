using ClassLibrary;
namespace OtusHW.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();
            var imageDownloader = new ImageDownloader();

            //подписка
            imageDownloader.DownloadStarted += notificationService.OnStartDownloading;
            imageDownloader.DownloadFinished += notificationService.OnFinishDownloadind;

            bool asd = imageDownloader.Download().IsCompleted;

            while (true)
            {
                Console.WriteLine("Нажмите клавишу 'a' для выхода или любую другую клавишу для проверки статуса скачивания");
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine(asd);
                }
                else
                {
                    break;
                }
            }
        }
    }
}