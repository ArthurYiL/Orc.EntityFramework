﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModuleInitializer.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Catel.IoC;
using Orc.EntityFramework.Tests.DbContext.Repositories;

/// <summary>
/// Class that gets called as soon as the module is loaded.
/// </summary>
/// <remarks>
/// This is made possible thanks to Fody.
/// </remarks>
public static class ModuleInitializer
{
    #region Methods

    /// <summary>
    /// Initializes the module
    /// </summary>
    public static void Initialize()
    {
        var serviceLocator = ServiceLocator.Default;

        serviceLocator.RegisterType<IDbContextCustomerRepository, DbContextCustomerRepository>(registrationType: RegistrationType.Transient);
        serviceLocator.RegisterType<IDbContextOrderRepository, DbContextOrderRepository>(registrationType: RegistrationType.Transient);
        serviceLocator.RegisterType<IDbContextProductRepository, DbContextProductRepository>(registrationType: RegistrationType.Transient);
        #endregion
    }
}