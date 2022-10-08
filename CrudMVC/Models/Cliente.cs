using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CrudMVC.Models
{
    [Table("CLIENTE")]
    public partial class Cliente
    {
        [Column("CPF")]
        [StringLength(50)]
        
        public string Cpf { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        
        public string Nome { get; set; }
        [Required]
        [Column("DATADENASCIMENTO")]
        [StringLength(50)]
        
        public string Datadenascimento { get; set; }
        [Required]
        [Column("SEXO")]
        [StringLength(50)]
       
        public string Sexo { get; set; }
        [Required]
        [Column("ENDERECO")]
        [StringLength(255)]
       
        public string Endereco { get; set; }
        [Required]
        [Column("ESTADO")]
        [StringLength(50)]
       
        public string Estado { get; set; }
        [Required]
        [Column("CIDADE")]
        [StringLength(255)]
        
        public string Cidade { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
