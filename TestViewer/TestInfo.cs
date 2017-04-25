using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestViewer
{
  class TestInfo
  {
    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual DateTime Created { get; set; }

    public virtual DateTime Updated { get; set; }

    public virtual string Author { get; set; }

    public virtual string Division { get; set; }
  }
}
