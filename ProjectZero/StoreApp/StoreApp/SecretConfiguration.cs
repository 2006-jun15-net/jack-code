using Microsoft.EntityFrameworkCore.Infrastructure;

namespace StoreApp
{
    internal class SecretConfiguration
    {
        internal const string ConnectionString = "Server=tcp:2020-revature-pflug.database.windows.net,1433;Initial Catalog=projectZero;Persist Security Info=False;User ID=jack;Password= Bluefridge122;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
    }
    //public class DbContextOptionsBuilder : Microsoft.EntityFrameworkCore.Infrastructure.IDbContextOptionsBuilderInfrastructure
    //{
    //    void IDbContextOptionsBuilderInfrastructure.AddOrUpdateExtension<TExtension>(TExtension extension)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}


