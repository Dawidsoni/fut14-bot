using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace FIFA_AUCTION {
    public class LoggerSave : LoggerBase {
        ExcHandler handler = new ExcHandler();
        string email;
        SmtpClient client;
        StreamWriter writer;

        public LoggerSave(string file, string email = null, SmtpClient client = null) {
            this.email = email;
            this.client = client;
            int count = 1;
            string curFile = new string(file.ToArray());
            bool ifEnd = false;
            while(ifEnd == false) {
                ifEnd = true;
                try {
                    this.writer = new StreamWriter(new FileStream(curFile, FileMode.Append));
                } catch (Exception exc) {
                    ifEnd = false;
                    curFile = file.Substring(0, file.Length - 5) + (count++).ToString() + file.Substring(file.Length - 5);
                }
            }
        }

        public void send(string message) {
            if (handler.contains(message) == false) {
                addMessage(message);
                handler.add(message);
                writer.WriteLine(Time.time() + " " + message);
                writer.Flush();
            }
        }

        public void send(Exception exc) {
            send("Złapano wyjątek: " + exc.GetType().ToString() + Environment.NewLine + exc.Message + Environment.NewLine + exc.StackTrace.ToString());
        }

        public void sendEmail(string email, SmtpClient client, string title, string body) {
            if (email == null || client == null) throw new Exception(this.ToString() +  " Nie ustawiono adresu email lub klienta w konstruktorze");
            bool czyKoniec = false;
            while (czyKoniec == false) {
                czyKoniec = true;
                try {
                    var message = new MailMessage(email, email) {
                        Subject = title,
                        Body = body
                    };
                    client.Send(message);
                } catch (Exception exc) {
                    czyKoniec = false;
                }
            }
        }

    }
}