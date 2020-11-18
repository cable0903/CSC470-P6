using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        private static List<Issue> _Issues = new List<Issue>();

        private string ValidateIssue(Issue issue)
        {
            string placeholder = "This is a placeHolder";
            return placeholder;
        }

        private bool IsDuplicate(string title)
        {
            return true;
        }

        public string Add(Issue issue)
        {
            initializeComponent();
        }

        public List<Issue> GetAll(int ProjectId)
        {
            return _ProjectId;
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
