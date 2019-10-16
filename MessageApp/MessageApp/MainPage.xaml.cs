using MessageApp.Services;
using System;
using Xamarin.Forms;

namespace MessageApp
{
    public partial class MainPage : ContentPage
    {
        MessageService messageService;

        public MainPage()
        {
            InitializeComponent();
            messageService = new MessageService();
        }

        public async void getMEssage(object sender, EventArgs args)
        {
            IsLoading();
            var message = await messageService.getMessageDay(4);
            lblMsg.Text = message.Texto;
            lblData.Text = message.DataExibicao.ToString("dd/MM/yyyy");
            Loaded();
        }

        public void BackMessage(object sender, EventArgs args)
        {
            btnMsg.IsVisible = true;
            btnBack.IsVisible = false;
            lblData.Text = "";
            lblMsg.Text = "Clique no botão para receber sua mensagem do dia";

        }


        public void IsLoading()
        {
            btnMsg.IsVisible = false;
            lblCarregandoMensagem.IsVisible = true;
            loaderMsg.IsVisible = true;
        }

        public void Loaded()
        {
            btnBack.IsVisible = true;
            lblCarregandoMensagem.IsVisible = false;
            loaderMsg.IsVisible = false;
        }
    }
}
