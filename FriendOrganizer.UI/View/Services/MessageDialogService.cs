using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrganizer.UI.View.Services
{
    public class MessageDialogService : IMessageDialogService
    {
        private static MetroWindow MetroWindow => (MetroWindow)Application.Current.MainWindow;

        public async Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title)
        {
            MahApps.Metro.Controls.Dialogs.MessageDialogResult result = await MetroWindow.ShowMessageAsync(title, text, MessageDialogStyle.AffirmativeAndNegative);

            return result == MahApps.Metro.Controls.Dialogs.MessageDialogResult.Affirmative
              ? MessageDialogResult.OK
              : MessageDialogResult.Cancel;
        }

        public async Task ShowInfoDialogAsync(string text)
        {
            await MetroWindow.ShowMessageAsync("Info", text);
        }
    }

    public enum MessageDialogResult
    {
        OK,
        Cancel
    }
}
