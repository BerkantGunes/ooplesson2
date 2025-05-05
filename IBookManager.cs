using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__
{
    public interface IBookManager
    {
        void Add();

        void Delete();

        void Update();

        IEnumerable<IKitaplar_> GetAll();



    }
}
