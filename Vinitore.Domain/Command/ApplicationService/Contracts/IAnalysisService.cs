﻿using System;
using System.Collections.Generic;
using System.Text;
using Vinitore.Domain.Command.Commands;

namespace Vinitore.Domain.Command.ApplicationService.Contracts
{
    public interface IAnalysisService
    {
        void AddAnalysis(AnalysisCommand command);
    }
}
