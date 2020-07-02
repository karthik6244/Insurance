using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Insurance.Domain.Banks;
namespace Insurance.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Bank> Bank { get; set; }

        void Save();
    }
}
