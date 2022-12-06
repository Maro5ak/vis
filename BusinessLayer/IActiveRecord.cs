using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public interface IActiveRecord<T> {
        void Insert(out string msg);
        void Update(out string msg);
        void Delete(out string msg);

    }
}
