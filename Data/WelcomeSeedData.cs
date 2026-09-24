using Univents.Models;

namespace Univents.Data;

public static class WelcomeSeedData
{
    public static readonly List<string> Categories = new()
    {
        "All Events",
        "Academic",
        "Social",
        "Sports",
        "Arts & Culture",
        "Career",
        "Tech",
        "Health & Wellness",
    };

    public static readonly List<EventItem> Events = new()
    {
        new EventItem { Id = 1, Title = "Spring Campus Festival", Org = "Student Union", Date = "Mar 22", Time = "2:00 PM", Category = "Social", Attending = 312, Color = "#c5e61c", Image = "https://images.unsplash.com/photo-1533174072545-7a4b6ad7a6c3?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 2, Title = "Tech Innovation Summit", Org = "CS Society", Date = "Mar 28", Time = "10:00 AM", Category = "Tech", Attending = 189, Color = "#4fc3f7", Image = "https://images.unsplash.com/photo-1540575467063-178a50c2df87?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 3, Title = "Cultural Night 2026", Org = "Multicultural Club", Date = "Apr 5", Time = "6:30 PM", Category = "Arts & Culture", Attending = 245, Color = "#ffb74d", Image = "https://images.unsplash.com/photo-1516450360452-9312f5e86fc7?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 4, Title = "Startup Pitch Night", Org = "Entrepreneurship Hub", Date = "Apr 10", Time = "7:00 PM", Category = "Career", Attending = 134, Color = "#ce93d8", Image = "https://images.unsplash.com/photo-1559136555-9303baea8ebd?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 5, Title = "Intramural Basketball Tourney", Org = "Athletics Dept.", Date = "Apr 12", Time = "9:00 AM", Category = "Sports", Attending = 98, Color = "#ef9a9a", Image = "https://images.unsplash.com/photo-1546519638405-a9d1ace0d4b4?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 6, Title = "Research Symposium", Org = "Graduate Council", Date = "Apr 18", Time = "11:00 AM", Category = "Academic", Attending = 210, Color = "#80cbc4", Image = "https://images.unsplash.com/photo-1532094349884-543559b7e07a?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 7, Title = "Mindfulness & Yoga Day", Org = "Wellness Center", Date = "Apr 20", Time = "8:00 AM", Category = "Health & Wellness", Attending = 76, Color = "#a5d6a7", Image = "https://images.unsplash.com/photo-1544367567-0f2fcb009e0b?w=400&h=220&fit=crop&auto=format" },
        new EventItem { Id = 8, Title = "Open Mic Night", Org = "Arts Collective", Date = "Apr 25", Time = "8:00 PM", Category = "Arts & Culture", Attending = 155, Color = "#ffcc80", Image = "https://images.unsplash.com/photo-1493225457124-a3eb161ffa5f?w=400&h=220&fit=crop&auto=format" },
    };

    public static readonly List<OrganizationItem> Organizations = new()
    {
        new OrganizationItem { Id = 1, Name = "CS Society", Members = 420, Events = 12, Tag = "Tech", Color = "#4fc3f7", Initial = "CS" },
        new OrganizationItem { Id = 2, Name = "Student Union", Members = 1820, Events = 34, Tag = "Social", Color = "#c5e61c", Initial = "SU" },
        new OrganizationItem { Id = 3, Name = "Multicultural Club", Members = 310, Events = 18, Tag = "Culture", Color = "#ffb74d", Initial = "MC" },
        new OrganizationItem { Id = 4, Name = "Entrepreneurship Hub", Members = 275, Events = 9, Tag = "Career", Color = "#ce93d8", Initial = "EH" },
        new OrganizationItem { Id = 5, Name = "Athletics Dept.", Members = 890, Events = 26, Tag = "Sports", Color = "#ef9a9a", Initial = "AD" },
        new OrganizationItem { Id = 6, Name = "Wellness Center", Members = 540, Events = 15, Tag = "Health", Color = "#a5d6a7", Initial = "WC" },
    };

    public static readonly List<RsvpItem> UpcomingRsvp = new()
    {
        new RsvpItem { Title = "Tech Innovation Summit", Date = "Mar 28", Org = "CS Society" },
        new RsvpItem { Title = "Cultural Night 2026", Date = "Apr 5", Org = "Multicultural Club" },
    };

    // Default joined orgs, mirrors `useState<number[]>([2])` in the Figma source.
    public static readonly HashSet<int> DefaultJoinedOrgs = new() { 2 };
}
