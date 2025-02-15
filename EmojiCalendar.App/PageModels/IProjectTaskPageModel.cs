using CommunityToolkit.Mvvm.Input;
using EmojiCalendar.App.Models;

namespace EmojiCalendar.App.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}