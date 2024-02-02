using System.ComponentModel.DataAnnotations;

namespace HTLMS.WebApp.Models;

public class Hotel
{
    public int HotelId { get; set; }

    [Required(ErrorMessage = "Please enter name")]
    public string HotelName { get; set;} = string.Empty;
    public string HotelDescription { get; set;} =string.Empty;
    public string HotelType { get; set; } = string.Empty;
    public string HotelAddress { get; set; } = string.Empty;
    public string HotelCode { get;set;}  = string.Empty;

    //[Display(Name = "HotelPhoneNumber")]
    //[DataType(DataType.PhoneNumber)]
    //[Required(ErrorMessage = "Please enter phone number")]
    //[Display(Name = "Phone Number")]
    //[DataType(DataType.PhoneNumber)]
    public string HotelPhoneNumber { get; set; } = string.Empty;


}
