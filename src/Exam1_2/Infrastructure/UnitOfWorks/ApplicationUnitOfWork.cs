﻿using Infrastructure.DbContexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {

        public IBookRepository Books { get; private set; }
        public ApplicationUnitOfWork(IApplicationDbContext dbContext,
            IBookRepository bookRepository) : base((DbContext)dbContext)
        {
            Books = bookRepository;
        }
    }
}
