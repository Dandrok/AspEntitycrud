using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Company
    {
        [Key]

        [Display(Name = "Departamento")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!")]
        [Display(Name = "Nome")]
        [MaxLength(20, ErrorMessage = "O campo Nome recebe no máximo 20 caracteres.")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!")]
        [Display(Name = "Telefone")]
        [MaxLength(25, ErrorMessage = "O campo Nome recebe no máximo 20 caracteres.")]
        //[Index("Departament_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!")]
        [Display(Name = "Endereço")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 20 caracteres.")]
        //[Index("Departament_Name_Index", IsUnique = true)]
        public string Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }


        [Required(ErrorMessage = "O campo Departamento é requerido!")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }


        [Required(ErrorMessage = "O campo Cidade é requerido!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }


        public virtual Departaments Departament { get; set; }

        public virtual City Cities { get; set; }
    }
}