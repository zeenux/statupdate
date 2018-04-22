namespace StatisticalUpdate
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using StatisticalUpdate.Models;
    public class ER : DbContext
    {
        // Your context has been configured to use a 'ER' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StatisticalUpdate.ER' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ER' 
        // connection string in the application configuration file.
        public ER()
            : base("name=ER")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Districts> districtList { get; set; }
        public virtual DbSet<SM> socialMob { get; set; }
        public virtual DbSet<Users> User { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}