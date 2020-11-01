﻿using System.Collections.Generic;

namespace P5
{
    public interface IIssueRepository
    {
        string Add(Issue issue);
        List<Issue> GetAll(int ProjectID);
        bool Remove(Issue issue);
        string Modify(Issue issue);
        int GetTotalNumberOfIssues(int ProjectID);
        List<string> GetIssuesBGyMonth(int ProjectID);
        List<string> GetIssuesByDiscoverer(int ProjectID);
        Issue GetIssueByID(int ID);
    }
}
