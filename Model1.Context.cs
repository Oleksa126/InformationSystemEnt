﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InformationSystemEnt
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class informationSystemEntities : DbContext
    {
        public informationSystemEntities()
            : base("name=informationSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
    
        [DbFunction("informationSystemEntities", "F_Get_Client")]
        public virtual IQueryable<F_Get_Client_Result> F_Get_Client(Nullable<int> idCl)
        {
            var idClParameter = idCl.HasValue ?
                new ObjectParameter("idCl", idCl) :
                new ObjectParameter("idCl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<F_Get_Client_Result>("[informationSystemEntities].[F_Get_Client](@idCl)", idClParameter);
        }
    
        public virtual ObjectResult<P_GetClientInfo_Result> P_GetClientInfo(Nullable<int> idClient)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("idClient", idClient) :
                new ObjectParameter("idClient", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_GetClientInfo_Result>("P_GetClientInfo", idClientParameter);
        }
    }
}
