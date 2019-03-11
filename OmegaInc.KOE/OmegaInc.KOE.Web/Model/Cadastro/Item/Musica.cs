using OmegaInc.KOE.Web.Model.Abstract;
using PetaPoco;
using System;

namespace OmegaInc.KOE.Web.Model.Cadastro.Item
{
    [System.ComponentModel.DataAnnotations.Schema.Table("cad_musicas")]    
    public class Musica : ParentBase
    {
        [Column]
        public string Titulo { get; set; }

        [Column]
        public DateTime DataLancamento { get; set; }

        [Column]
        public decimal Valor { get; set; }

        [Column]
        public string URL { get; set; }

        [Column("guid_album")]
        public long AlbumId { get; set; }
    }
}
