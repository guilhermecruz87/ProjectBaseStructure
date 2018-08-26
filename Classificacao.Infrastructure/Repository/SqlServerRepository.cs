using System;
using System.Data.SqlClient;

namespace Classificacao.Infrastructure.Repository
{
    public class SqlServerRepository : IDisposable
    {
        protected const string connectionStringClassificacao = @"Data Source=GUILHERME-PC\SQLSERVER2014;Initial Catalog=ClassificacaoPY;User ID=sa;Password=220607;Connection Timeout=300";
        protected const string connectionStringPlanetaY = @"Data Source=GUILHERME-PC\SQLSERVER2014;Initial Catalog=PYClienteMigra;User ID=sa;Password=220607;Connection Timeout=300";
        protected const string connectionStringLogPY = @"Data Source=GUILHERME-PC\SQLSERVER2014;Initial Catalog=LogPY;User ID=sa;Password=220607;Connection Timeout=300";

        private SqlConnection _connectionClassificacao = null;
        private SqlConnection _connectionPlanetaY = null;
        private SqlConnection _connectionLogPY = null;

        protected SqlConnection DataBaseClassificacao
        {
            get
            {
                if (_connectionClassificacao == null)
                    _connectionClassificacao = new SqlConnection(connectionStringClassificacao);

                return _connectionClassificacao;
            }
        }

        protected SqlConnection DataBasePlanetaY
        {
            get
            {
                if (_connectionPlanetaY == null)
                    _connectionPlanetaY = new SqlConnection(connectionStringClassificacao);

                return _connectionPlanetaY;
            }
        }

        protected SqlConnection DataBaseLogPY
        {
            get
            {
                if (_connectionLogPY == null)
                    _connectionLogPY = new SqlConnection(connectionStringClassificacao);

                return _connectionLogPY;
            }
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
