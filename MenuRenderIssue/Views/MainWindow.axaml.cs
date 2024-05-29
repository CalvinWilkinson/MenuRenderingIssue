using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;

namespace MenuRenderIssue.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var dialogParams = new MessageBoxStandardParams
        {
            InputParams = new InputParams { Label = "This is a message", Multiline = false, DefaultValue = "Default value", },
            ButtonDefinitions = ButtonEnum.OkCancel,
            Topmost = true,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            SystemDecorations = SystemDecorations.Full,
            MinWidth = 300,
        };

        var msgBox = MessageBoxManager.GetMessageBoxStandard(dialogParams);

        await msgBox.ShowAsPopupAsync(this);
    }
}
