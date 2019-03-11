using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using PetaPoco;
using PetaPoco.Providers;


namespace OmegaInc.KOE.Repositories.Abstract
{
    public abstract class RepositoryBase<TEntity>
    {
        #region Private Properties

        private string _connectionString;

        private IDatabase _db;

        #endregion Private Properties

        #region Protected Properties

        protected IDatabase Db => _db;

        #endregion Protected Properties

        #region Constructor

        public RepositoryBase(IConfiguration configuration)
        {
            _connectionString = "Server=127.0.0.1;Uid=root;Pwd=;Database=petapoco;Port=3306"; //configuration.GetValue<string>("DBInfo:ConnectionString");

            _db = DatabaseConfiguration.Build()
                    .UsingConnectionString(_connectionString)
                    .UsingProvider<MySqlDatabaseProvider>()
                    .Create();

            //_db.Execute(LoadTextResource("mysql_init.sql"));
        }

        #endregion Constructor

        #region Public Methods

        public abstract void Add(TEntity item);

        public abstract void Remove(int id);

        public abstract void Update(TEntity item);

        public abstract TEntity FindByID(int id);

        public abstract IEnumerable<TEntity> FindAll();

        #endregion Public Methods

        #region Private Methods

        private string LoadTextResource(string name)
        {
            var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Scripts", name);
            System.Console.WriteLine(path);
            System.IO.StreamReader r = new System.IO.StreamReader(path);
            string str = r.ReadToEnd();
            r.Close();

            return str;
        }

        #endregion Private Methods
    }
}
