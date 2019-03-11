using System;
using System.ComponentModel.DataAnnotations.Schema;
using PetaPoco;
using ColumnAttribute = PetaPoco.ColumnAttribute;

namespace OmegaInc.KOE.Web.Model.Abstract
{
    [PrimaryKey("guid", AutoIncrement = false)]
    public abstract class ParentBase
    {
        [Column("guid")]
        public virtual int Id { get; set; }
        [Column]
        public virtual DateTime DataCriacao { get; set; }
        [Column]
        public virtual DateTime DataAlteracao { get; set; }
    }
}
