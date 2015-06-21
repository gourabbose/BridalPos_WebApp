﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BridalPOS.Model.Core
{
	/// <summary>Class which represents the DataContext for the project / group 'LLBLGenProProject1'</summary>
	public partial class LLBLGenProProject1DataContext : DbContext 
	{
		#region Extensibility Method Definitions
		partial void OnContextCreated();
		#endregion
		
		#region Class Member Declarations
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="LLBLGenProProject1DataContext"/> class using the connection string found in the 'LLBLGenProProject1' section of the application configuration file.</summary>
		public LLBLGenProProject1DataContext() : base("name=ConnectionString.SQL Server (SqlClient)")
		{
			Initialize();
		}
		
		/// <summary>Initializes a new instance of the <see cref="LLBLGenProProject1DataContext"/> class</summary>
		public LLBLGenProProject1DataContext(string connectionString) : base(connectionString)
		{
			Initialize();
		}
		
		/// <summary>This method is called when the model for a derived context has been initialized, but before the model has been locked down and used to initialize the context.  The default
		/// implementation of this method does nothing, but it can be overridden in a derived class such that the model can be further configured before it is locked down.</summary>
		/// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
		/// <remarks>Typically, this method is called only once when the first instance of a derived context is created.  The model for that context is then cached and is for all further instances of
		/// the context in the app domain.  This caching can be disabled by setting the ModelCaching property on the given modelBuilder, but note that this can seriously degrade performance.
		/// More control over caching is provided through use of the DbModelBuilder and DbContextFactory classes directly.
		/// </remarks>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			new LLBLGenProProject1ModelBuilder().BuildModel(modelBuilder);
		}

		/// <summary>Initializes this instance</summary>
		private void Initialize()
		{
			OnContextCreated();
		}
		

		#region Class Property Declarations
		#endregion
	}
}

 