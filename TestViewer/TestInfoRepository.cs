using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace TestViewer
{
  class TestInfoRepository
  {
    public void Add(TestInfo testInfo)
    {
      using (ISession session = NHibernateHelper.OpenSession())
      using (ITransaction transaction = session.BeginTransaction())
      {
        session.Save(testInfo);
        transaction.Commit();
      }
    }
  }
}
