using Avalonia;
using Avalonia.Markup.Xaml;

namespace DBManager.Ui
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}