namespace LastApp;

public partial class LastAppDetailPage : ContentPage
{
	public LastAppDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLastResult(categoryName);
		Title = categoryName;
	}

	private void DisplayLastResult(string categoryName)
	{
		MusicData musicData = new MusicData();
		switch(categoryName)
		{
			case "Guitar":
				CvLast.ItemsSource = musicData.Guitars; 
				break;
            case "Bass":
                CvLast.ItemsSource = musicData.Bass; 
				break;
            case "Earpone":
                CvLast.ItemsSource = musicData.Earphone; 
				break;
            case "Speaker":
                CvLast.ItemsSource = musicData.Speaker; 
				break;
            case "Drum":
                CvLast.ItemsSource = musicData.Drum; 
				break;
            case "Keyboard":
                CvLast.ItemsSource = musicData.Keyboards; 
				break;
			default:
				break;
        }
	}
	private async void CvLast_SelectionChanged(object sender,SelectionChangedEventArgs e)
	{
		var selectedItem = e.CurrentSelection.FirstOrDefault() as MusicItem;
		await TextToSpeech.SpeakAsync(selectedItem.Name);
	}
}