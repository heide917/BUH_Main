using System;
using System.Collections.Generic;
using AutoMapper;
using BUH.DAL.Models;
using BUH.Domain.Repositories;

namespace BUH.DAL.Repositories
{
    public class KekRepository : IKekRepository
    {
        private readonly BUHContext context;
        private readonly IMapper mapper;
        private bool disposed = false;

        public KekRepository(IMapper mapper)
        {
            this.context = new BUHContext();
            this.mapper = mapper;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }

            this.disposed = true;
        }

        public Domain.Models.Kek GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Models.Kek> GetCollection()
        {
            return this.mapper.Map<IEnumerable<Kek>, IEnumerable<Domain.Models.Kek>>(this.context.Keks);
        }

        public int Insert(Domain.Models.Kek entity)
        {
            Kek entityToInsert = this.context.Keks.Create();
            this.mapper.Map(entity, entityToInsert);
            this.context.Keks.Add(entityToInsert);
            this.context.SaveChanges();
            return entityToInsert.Id;
        }

        public void Update(Domain.Models.Kek entity)
        {
            throw new NotImplementedException();
        }
    }
}
