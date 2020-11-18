using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _Statuses = new List<IssueStatus>();

        void Add(int Id, string value)
        {

        }

        List<IssueStatus> GetAll()
        {

        }

        int GetIdByStatus(string value)
        {

        }

        string GetValueById(int Id)
        {

        }



    }
}
