namespace ETS2Tachograph;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //    count++;
    //    CounterLabel.Text = $"Current count: {count}";

    //    SemanticScreenReader.Announce(CounterLabel.Text);
    //}

    private void OnDriveClicked(object sender, EventArgs e)
    {
        // state machine -> drive
    }

    private void OnWorkClicked(object sender, EventArgs e)
    {
        // state machine -> work
    }

    private void OnStandbyClicked(object sender, EventArgs e)
    {
        // state machine -> standby
    }

    private void OnRestClicked(object sender, EventArgs e)
    {
        // state machine -> rest
    }

    private void OnSettingsClicked(object sender, EventArgs e)
    {
        // open settings component
    }
}
