using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.TransferManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;
using Vinitore.Domain.Query.ViewModels;
using Vinitore.Domain.Query.Views;
using Vinitore.Infrastructure.DbModel;

namespace Vinitore.Infrastructure.EntityMappers
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<WineTb, Wine>();
                cfg.CreateMap<WineTb, WineGridViewModel>();
                cfg.CreateMap<WineTb, WineDetailsViewModel>();
                cfg.CreateMap<WineTb, WineSummaryView>();

                cfg.CreateMap<BarrelTb, Barrel>();
                cfg.CreateMap<BarrelTb, BarrelView>();
                cfg.CreateMap<BarrelTb, BarrelSummaryView>();

                cfg.CreateMap<TransferTb, TransferView>();

                cfg.CreateMap<Wine, WineTb>();
                cfg.CreateMap<Barrel, BarrelTb>();
                cfg.CreateMap<Transfer, TransferTb>();
            });
        }
    }
}
