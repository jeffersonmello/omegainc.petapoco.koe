using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmegaInc.KOE.Web.Model.Abstract
{
    public abstract class Base
    {
        [Column("guid")]
        public virtual int Id { get; set; }
        [Column]
        public virtual DateTime DataCriacao { get; set; }
        [Column]
        public virtual DateTime DataAlteracao { get; set; }
    }
}
