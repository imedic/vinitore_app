using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;
using Vinitore.Domain.Command.DomainModels.BarrelManagment;
using Vinitore.Domain.Command.DomainModels.WineManagment;
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
                cfg.CreateMap<BarrelTb, Barrel>();

                cfg.CreateMap<Wine, WineTb>();
                cfg.CreateMap<Barrel, BarrelTb>();
            });
        }
    }
}
