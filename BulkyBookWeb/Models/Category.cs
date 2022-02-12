using System.ComponentModel.DataAnnotations;
namespace BulkyBookWeb.Models;

public class Categroy
{ // notice curlybrace starts a new line?


    [Key]    //Don't forget to import the Library. Sets column as Primary key (Identity Column)
    public int Id { get; set; } //keyword 'prop' + enterKey
    [Required]    //Same as null:false;
    public string Name { get; set; } = "guest";
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now; //sets default
}

