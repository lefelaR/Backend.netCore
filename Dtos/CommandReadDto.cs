using System.ComponentModel.DataAnnotations;

namespace Backend.Netcore.Dtos
{
    public class CommandReadDto
    {

        
        public int Id { get; set; }
        
        public string? HowTo { get; set; }
        
        public string? Platform { get; set; }
        
        public string? CommandLine { get; set; }
    }
}