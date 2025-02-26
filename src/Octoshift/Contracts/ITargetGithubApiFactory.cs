using OctoshiftCLI.Services;

namespace OctoshiftCLI.Contracts;

public interface ITargetGithubApiFactory
{
    GithubApi Create(string apiUrl = null, string targetPersonalAccessToken = null, string gqlUrl = null);
}
