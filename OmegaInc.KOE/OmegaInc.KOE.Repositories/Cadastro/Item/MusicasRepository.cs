using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using OmegaInc.KOE.Repositories.Abstract;
using OmegaInc.KOE.Web.Model.Cadastro.Item;
using PetaPoco;
using PetaPoco.Providers;

namespace OmegaInc.KOE.Repositories.Cadastro.Item
{
    public class MusicasRepository : RepositoryBase<Musica>
    {
        public MusicasRepository(IConfiguration configuration)
            :base(configuration)
        {
        }

        public override void Add(Musica item)
        {
            Db.Insert(item);
        }

        public override IEnumerable<Musica> FindAll()
        {
            return Db.Query<Musica>("SELECT * FROM cad_musica");
        }

        public override Musica FindByID(int id)
        {
            return Db.Single<Musica>(id);
        }

        public override void Remove(int id)
        {
            var item = Db.Single<Musica>(id);
            Db.Delete(item);
        }

        public override void Update(Musica item)
        {
            Db.Update(item);
        }
    }
}
