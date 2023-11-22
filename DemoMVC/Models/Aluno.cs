using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public bool Active { get; set; }
}
