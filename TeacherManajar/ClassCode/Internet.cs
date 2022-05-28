using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TeacherManajar.ClassCode
{
    class Internet
    {
        /// <summary>
        /// Перевірка статусу підключення до мережі
        /// </summary>
        /// <returns></returns>
        public static bool CheckInternetConection()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void ErrorMessage()
        {
            MessageBox.Show("Не вдалося підключитися до бази даних. Відсутній доступ до інтернету. Перевірте підключення до мережі і спробуйте повторити спробу іще раз.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
