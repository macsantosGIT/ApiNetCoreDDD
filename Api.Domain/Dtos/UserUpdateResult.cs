using System;

namespace Api.Domain.Dtos
{
    public class UserDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email  { get; set; }
        public DateTime UpdateAt { get; set; }
        
    }
}