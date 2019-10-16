using MessageApp.Context;
using MessageApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.Services
{
    public class MessageService
    {
        HttpClient client = new HttpClient();

        public async Task<Message> getMessageDay(int id)
        {
            var dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MessageOffline2.db");
            try
            {
                using (var db = new MessageAppContext(dbPath))
                {
                    //verifica se já possui alguma mensagem cadastrada no banco local para hoje
                    //não havendo, será feito uma busca na api para trazer a mensagem do dia e salvar no banco local
                    var haveMessage = db.Messages
                        .Where(x => x.DataExibicao.Day == DateTime.Now.Day
                                && x.DataExibicao.Month == DateTime.Now.Month
                                && x.DataExibicao.Year == DateTime.Now.Year).FirstOrDefault();
                    if (haveMessage == null)
                    {
                        Task<string> response = client.GetStringAsync("http://34.69.226.201/api/api/message/MessageDay");
                        var teste = await response;
                        var message = JsonConvert.DeserializeObject<Message>(teste);

                        // Verifica se o banco de dados foi criado
                        db.Database.EnsureCreated();
                        db.Add(message);
                        db.SaveChanges();
                        return message;
                    }
                    else
                    {
                        return haveMessage;
                    }
                }
            }
            catch (Exception e)
            {
                return new Message() { Texto = "Erro ao obter a mensagem do dia" };
            }
        }
    }
}
