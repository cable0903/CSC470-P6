using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IIssueRepository
    {
        public string Add(Issue issue);

        public List<Issue> GetAll(int ProjectId)
        {

        }

        public bool Remove(Issue issue)
        {
            
        }

        public string Modify(Issue issue)
        {
            
        }

        public int NumberOfIssues(int ProjectId)
        {

        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {

        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {

        }

        public Issue GetIssueById(int Id)
        {

        }
    }
}
