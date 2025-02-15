using EmojiCalendar.App.Models;
using EmojiCalendar.App.PageModels;

namespace EmojiCalendar.App.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}