using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.Barrel;
using Vinitore.Domain.Command.DomainModels.Wine;
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
