using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}