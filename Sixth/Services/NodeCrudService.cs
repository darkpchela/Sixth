using Microsoft.EntityFrameworkCore;
using Sixth.Interfaces;
using Sixth.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sixth.Services
{
    public class NodeCrudService : INodeCrudService
    {
        private readonly AppDbContext dbContext;

        public NodeCrudService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> Create(Node node)
        {
            await dbContext.Nodes.AddAsync(node);
            await dbContext.SaveChangesAsync();
            return node.Id;
        }

        public async Task<Node> Get(int id)
        {
            var node = await dbContext.Nodes.FindAsync(id);
            return node;
        }

        public async Task<IEnumerable<Node>> GetAll()
        {
            var nodes = await dbContext.Nodes.AsNoTracking().ToListAsync();
            return nodes;
        }

        public async Task Update(Node node)
        {
            dbContext.Nodes.Update(node);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var node = await dbContext.Nodes.FindAsync(id);
            if(node!= null)
            {
                dbContext.Nodes.Remove(node);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}