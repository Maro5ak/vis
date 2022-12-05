using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    internal interface IActiveRecord<T> {
        void Insert();
        void Update();
        void Delete();

    }
}
