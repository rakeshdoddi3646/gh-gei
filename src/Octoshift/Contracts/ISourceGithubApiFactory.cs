using OctoshiftCLI.Services;

namespace OctoshiftCLI.Contracts;

public interface ISourceGithubApiFactory
{
    GithubApi Create(string apiUrl = null, string sourcePersonalAccessToken = null, string gqlUrl = null);
    GithubApi CreateClientNoSsl(string apiUrl = null, string sourcePersonalAccessToken = null, string gqlUrl = null);
}
