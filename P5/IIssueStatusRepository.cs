﻿using System.Collections.Generic;

namespace P5
{
    public interface IIssueStatusRepository
    {
        void Add(int ID, string value);
        List<IssueStatus> GetAll(string value);
        int GetIdByStatus(string value);
        string GetValueByID(int ID);
    }
}
