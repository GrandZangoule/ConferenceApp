using CommunityToolkit.Mvvm.ComponentModel;

namespace MyConference.Models;

public partial class Session : ObservableObject
{
    // Static
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string StartTimeDisplay => $"{Start:t}";
    public string DayDisplay => $"{Start:MMM} {Start:d}";
    public Speaker Speaker { get; set; } = new Speaker
    {
        Name = "Oscar Eta Jr.",
        Company = "Green Mantis, LLC",
        Description = "Oscar Eta Jr. is a Principal Lead Engineer.",
        Title = "Principal Lead Engineer"
    };

    // Dynamic
    [ObservableProperty]
    bool inAgenda;
}
