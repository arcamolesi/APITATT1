﻿using System.ComponentModel.DataAnnotations;

namespace APITATT1.Model
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        [StringLength(35)]
        public string Nome { get; set; }

        [Required]
        [StringLength(40)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
       
    }
}
