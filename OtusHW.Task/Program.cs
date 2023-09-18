using MyLibrary;
namespace OtusHW.Tasksf
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var notificationService = new NotificationService();
            var imageDownloader = new ImageDownloader();

            //подписка
            imageDownloader.DownloadStarted += notificationService.OnStartDownloading;
            imageDownloader.DownloadFinished += notificationService.OnFinishDownloadind;

            Task downloading = imageDownloader.Download();//создаётся таска асинхроного метода, чтобы потом её проверить на completed
            

            while (true)
            {
                Console.WriteLine("Нажмите клавишу 'a' для выхода или любую другую клавишу для проверки статуса скачивания");
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.A)
                {
                    Console.Clear();
                    bool asd = downloading.IsCompleted;// чекаем таску, а не метод
                    Console.WriteLine("Is downloaded: "+ asd);
                }
                else
                {
                    break;
                }
            }
        }
    }
}