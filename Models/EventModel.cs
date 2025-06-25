using System.ComponentModel.DataAnnotations;

public class EventModel
    {
        [Required(ErrorMessage = "Event Name is required")]
        public string EventName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Event Date is required")]
        public DateTime? EventDate { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;
    }