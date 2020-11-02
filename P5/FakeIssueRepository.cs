﻿using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public string EMPTY_DISCOVERER_ERROR = "A Discoverer is required";
        public string DUPLICATE_TITLE_ERROR = "That title already exists!";

        private static List<Issue> Issues;

        FakeIssueRepository()
        {

        }

        public string Add(Issue issue)
        {
            if (isDuplicate(issue.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if(issue.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectID)
        {
            List<Issue> IssueList = new List<Issue>();
            foreach(Issue issue in Issues)
            {
                if(issue.ProjectID == ProjectID)
                {
                    IssueList.Add(issue);
                }
            }
            return IssueList;
        }

        public int GetTotalNumberOfIssues(int ProjectID)
        {
            int issueCount = 0;
            foreach(Issue issue in Issues)
            {
                if(issue.ProjectID == ProjectID)
                {
                    issueCount++;
                }
            }
            return issueCount;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectID)
        {
            List<string> Discs = new List<string>();
            foreach(Issue issue in Issues)
            {
                if(ProjectID == issue.ProjectID)
                {
                    Discs.Add(issue.Discoverer);
                }
            }
            return Discs;
        }

        public List<string> GetIssuesByMonth(int ProjectID)
        {
            List<string> IsMonth = new List<string>();
            return IsMonth;
        }

        public Issue GetIssueByID(int ID)
        {
            Issue foundIssue = new Issue();
            foreach(Issue issue in Issues)
            {
                if(ID == issue.ID)
                {
                    foundIssue = issue;
                }
            }
            return foundIssue;
        }
        public bool isDuplicate(string title)
        {
            bool isDup = false;
            foreach(Issue issue in Issues)
            {
                if(issue.Title == title)
                {
                    isDup = true;
                }
            }
            return isDup;
        }
    }
}
