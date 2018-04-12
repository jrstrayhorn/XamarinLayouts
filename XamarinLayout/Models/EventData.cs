using System;
using System.Collections.Generic;

namespace XamarinLayout.Models
{
    public static class EventData
    {
        static List<Event> _allEvents;
        public static List<Event> AllEvents
        {
            get
            {
                if (_allEvents == null)
                {
                    _allEvents = new List<Event>() {
                        new Event {
                            Title = "Case Observation",
                            Location = "University Hospital",
                            Address = "Chicago IL, 60007",
                            Status = Status.Assigned,
                            Assignment = "Rick Hufstetler, +1 More",
                            Time = "8:00 AM",
                            Length = "1h 30m",
                            Color = "Green"
                        },
                        new Event {
                            Title = "Case Observation 1",
                            Location = "UC Health West Chester Hospital",
                            Address = "West Chester, OH, 45069",
                            Status = Status.Pending,
                            Assignment = "Unassigned",
                            Time = "8:00 AM",
                            Length = "2h 45m",
                            Color = "Gray"
                        },
                        new Event {
                            Title = "Case Observation",
                            Location = "Good Samaritan Hospital",
                            Address = "375 Dixmyth Ave, Cincinnati, OH",
                            Status = Status.ApprovalRequired,
                            Assignment = "",
                            Time = "10:00 AM",
                            Length = "3h 30m",
                            Color = "#FFA500"
                        },
                        new Event {
                            Title = "Cadaver Lab",
                            Location = "University Hospital",
                            Address = "Chicago IL, 60007",
                            Status = Status.Assigned,
                            Assignment = "Rick Hufstetler, +1 More",
                            Time = "1:00 PM",
                            Length = "3h 30m",
                            Color = "Green"
                        }
                    };
                }
                return _allEvents;
            }
        }
    }

   
}
