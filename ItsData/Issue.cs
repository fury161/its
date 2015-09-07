using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItsData
{
    public class Issue
    {
        public int IssueId { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public Issue ConvertFromEntity(Issues Entity)
        {
            IssueId = Entity.IssueId;
            Subject = Entity.Subject;
            Description = Entity.Description;

            return this;
        }

        public static List<Issue> GetIssues()
        {
            List<Issue> Result = new List<Issue>();

            using (ItsEntities Context = new ItsEntities())
            {
                foreach (var DBIssue in Context.Issues)
                {
                    Result.Add(new Issue().ConvertFromEntity(DBIssue));
                }
            }

            return Result;
        }

        public void Save()
        {
            if (IssueId == 0) SaveNew();
            else SaveOld();
        }

        private void SaveNew()
        {
            using (ItsEntities Context = new ItsEntities())
            {
                Issues DBIssue = new Issues()
                {
                    Subject = Subject,
                    Description = Description
                };

                Context.Issues.Add(DBIssue);

                Context.SaveChanges();
                IssueId = DBIssue.IssueId;
            }
        }

        private void SaveOld()
        {
            using (ItsEntities Context = new ItsEntities())
            {
                Issues DBIssue = Context.Issues.Where(p => p.IssueId == IssueId).FirstOrDefault();
                if (DBIssue == null) return;

                DBIssue.Subject = Subject;
                DBIssue.Description = Description;

                Context.SaveChanges();
            }
        }
    }
}
