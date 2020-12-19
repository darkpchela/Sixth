using Sixth.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sixth.Interfaces
{
    public interface INodeCrudService
    {
        Task<int> Create(Node node);

        Task<Node> Get(int id);

        Task<IEnumerable<Node>> GetAll();

        Task Update(Node node);
    }
}