using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MessageLengthApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var messageEntry = new Entry();
            var messageLabel = new Label();

            messageEntry.TextChanged += (s, e) =>
            {
                var messageLength = e.NewTextValue.Length;
                messageLabel.Text = $"Довжина повідомлення: {messageLength} символів";
            };

            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Введіть повідомлення:"
                    },
                    messageEntry,
                    messageLabel
                }
            };
        }
        private void OnSendClicked(object sender, EventArgs e)
        {
            var messageLength = messageEntry.Text.Length;
            messageLengthLabel.Text = $"Length of message: {messageLength}";
        }


    }
}
