using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GitHistory
{
    public class RepositoriesSetting
    {

        public List<RepositorySetting> Repositories { get; set; }

        public RepositoriesSetting()
        {
            Repositories = new List<RepositorySetting>();
        }

        public void AddRepository(RepositorySetting repository)
        {
            if (!Repositories.Contains(repository))
            {
                Repositories.Add(repository);
            }
        }
        public void DeleteRepository(RepositorySetting repository)
        {
            if (Repositories.Contains(repository))
            {
                Repositories.Remove(repository);
            }
        }

    }

    public class RepositorySetting : IEquatable<RepositorySetting>
    {
        public string RepositoryPath { get; set; }
        public int NumberOfCommits { get; set; }
        public int NumberOfTags { get; set; }
        public DateTimeOffset HistoryDateTime { get; set; }

        public FetchType FetchType { get; set; }

        public RepositorySetting()
        {

        }
        public RepositorySetting(string repositoryPath, int numberOfCommits,int numberOfTags, DateTime historyDateTime, FetchType fetchType)
        {
            RepositoryPath = repositoryPath;
            NumberOfCommits = numberOfCommits;
            numberOfTags = numberOfTags;
            HistoryDateTime = historyDateTime;
            FetchType = fetchType;
        }

        public bool Equals(RepositorySetting other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return RepositoryPath == other.RepositoryPath && NumberOfCommits == other.NumberOfCommits &&
                   NumberOfTags == other.NumberOfTags &&  HistoryDateTime.Equals(other.HistoryDateTime) && FetchType == other.FetchType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((RepositorySetting)obj);
        }

        public override int GetHashCode()
        {
#if NETCOREAPP3_1
            return HashCode.Combine(RepositoryPath, NumberOfCommits, HistoryDateTime, (int) FetchType);
#else
            return (RepositoryPath.GetHashCode() * 379) + (NumberOfCommits) + (NumberOfTags) + (HistoryDateTime.GetHashCode() * 379);
#endif
        }

        public override string ToString() => $"{nameof(RepositoryPath)}: {RepositoryPath}, {nameof(NumberOfCommits)}: {NumberOfCommits}, {nameof(NumberOfTags)}: {NumberOfTags}, {nameof(HistoryDateTime)}: {HistoryDateTime}, {nameof(FetchType)}: {FetchType}";
    }

    public enum FetchType
    {
        Count,
        DateTime,
    }
}
