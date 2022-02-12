namespace BulkyBookWeb.Models;

public class Categroy
{ // notice curlybrace starts a new line?

    public int Id { get; set; } //keyword 'prop' + enterKey
    public string Name { get; set; } = "guest";
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now; //sets default
}

