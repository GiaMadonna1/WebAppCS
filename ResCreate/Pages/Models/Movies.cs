using System.ComponentModel.DataAnnotations;

namespace ResCreate.Models;

public class Movie
{
    public int Id {get;set;}
    public string? Title {get;set;}
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get;set;}
    public string? Genre {get;set;}
    public decimal Price {get;set;}
}

/* An Id field to provide a primary key for the db.

    A datatype attribute to specify the type of data in the Release
    Date field. With this attribute: The user is not required
    to enter information about the time and only the date is
    displayed. 

    The question mark after string indicates that the property
    is nullable. 
*/
