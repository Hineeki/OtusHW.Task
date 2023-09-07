using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NotificationService
    {
        public void OnStartDownloading()
        {
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n");
        }
        public void OnFinishDownloadind() 
        {
            Console.WriteLine("Успешно скачал \"{1}\" из \"{1}\"");
        }
    }
}
