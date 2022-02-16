using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MonitoriaMVC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public String Nome { get; set; }
        [Required]
        [StringLength(50)]
        public String Email { get; set; }
        [Required]
        [StringLength(50)]
        public String Senha { get; set; }
    }
}
