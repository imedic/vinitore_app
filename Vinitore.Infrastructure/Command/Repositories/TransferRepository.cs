using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.DomainModels.TransferManagment;
using Vinitore.Domain.Command.InfrastructureContracts;
using Vinitore.Infrastructure.DbModel;
using Vinitore.Infrastructure.DbModel.Context;

namespace Vinitore.Infrastructure.Command.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly CommandContext _context;

        public TransferRepository(
            CommandContext context    
        )
        {
            _context = context;
        }
        public void AddTransfer(Transfer transfer)
        {
            var record = Mapper.Map<TransferTb>(transfer);
            _context.Transfers.Add(record);
            _context.SaveChanges();
        }
    }
}
