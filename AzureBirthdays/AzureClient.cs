using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AzureBirthdays {

  //-------------------------------------------------------------------------------------------------------------------
  //
  /// <summary>
  /// Authentication Event Arguments
  /// </summary>
  //
  //-------------------------------------------------------------------------------------------------------------------

  public sealed class AuthenticationEventArgs : EventArgs {
    #region Create

    public AuthenticationEventArgs(string url, string code) {
      Url = url;
      Code = code;
    }

    #endregion Create

    #region Public

    /// <summary>
    /// Url To Connect
    /// </summary>
    public string Url { get; }

    /// <summary>
    /// Code To Provide
    /// </summary>
    public string Code { get; }

    #endregion Public
  }

  //-------------------------------------------------------------------------------------------------------------------
  //
  /// <summary>
  /// Authentication
  /// </summary>
  //
  //-------------------------------------------------------------------------------------------------------------------

  public sealed class Authentication : IAuthenticationProvider {
    #region Private Data

    private readonly IPublicClientApplication m_MsalClient;
    private readonly string[] m_Scopes;
    private IAccount m_UserAccount;

    #endregion Private Data

    #region Algorithm

    private static (string code, string uri) ParseMessage(string message) {
      return (
        Regex.Match(message, @"code\s+(?<code>[A-Za-z0-9]+)").Groups["code"].Value,
        Regex.Match(message, @"https://[A-Za-z0-9/.:]+").Value
      );
    }

    #endregion Algorithm

    #region Create

    /// <summary>
    /// Standard constructor
    /// </summary>
    public Authentication(string appId, IEnumerable<string> scopes) {
      if (appId is null)
        throw new ArgumentNullException(nameof(appId));
      if (scopes is null)
        throw new ArgumentNullException(nameof(scopes));

      m_Scopes = scopes.ToArray();

      m_MsalClient = PublicClientApplicationBuilder
        .Create(appId)
        .WithAuthority(AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount, true)
        .Build();

      //m_Client = new GraphServiceClient(this);
    }

    #endregion Create

    #region Public

    /// <summary>
    /// 
    /// </summary>
    public async Task<string> GetAccessToken() {
      // If there is no saved user account, the user must sign-in
      if (m_UserAccount is null) {
        try {
          var result = await m_MsalClient.AcquireTokenWithDeviceCode(
            m_Scopes,
            callback => {
              var (code, uri) = ParseMessage(callback.Message);
              var evt = Authenticate;

              evt.Invoke(this, new AuthenticationEventArgs(uri, code));

              return Task.FromResult(0);
            }).ExecuteAsync();

          m_UserAccount = result.Account;

          return result.AccessToken;
        }
        catch (TaskCanceledException) {
          return null;
        }
        catch (TimeoutException) {
          return null;
        }
      }
      else {
        // If there is an account, call AcquireTokenSilent
        // By doing this, MSAL will refresh the token automatically if
        // it is expired. Otherwise it returns the cached token.

        var result = await m_MsalClient
            .AcquireTokenSilent(m_Scopes, m_UserAccount)
            .ExecuteAsync();

        return result.AccessToken;
      }
    }

    // This is the required function to implement IAuthenticationProvider
    // The Graph SDK will call this function each time it makes a Graph
    // call.
    public async Task AuthenticateRequestAsync(HttpRequestMessage requestMessage) {
      requestMessage.Headers.Authorization =
          new AuthenticationHeaderValue("bearer", await GetAccessToken());
    }

    /// <summary>
    /// Authenticate event
    /// </summary>
    public event EventHandler<AuthenticationEventArgs> Authenticate;

    /// <summary>
    /// Graph Client
    /// </summary>
    //public GraphServiceClient Client => m_Client;

    #endregion Public
  }

  //-------------------------------------------------------------------------------------------------------------------
  //
  /// <summary>
  /// Azure Client
  /// </summary>
  //
  //-------------------------------------------------------------------------------------------------------------------

  public static class AzureClient {
    #region Private Data

    private const string ApplicationId = "d2d7067e-15ac-4f1e-8130-75bc4a6ce717";

    private static readonly IReadOnlyList<string> Scope = new List<string>() {
      "User.Read",
      "User.ReadWrite",
      "User.ReadBasic.All",
      //"User.ReadWrite.All",
    };

    private static Authentication m_Authentication;

    private static GraphServiceClient m_Client;

    #endregion Private Data

    #region Public

    /// <summary>
    /// Build Client with authentication callback
    /// </summary>
    /// <param name="callback"></param>
    /// <returns></returns>
    public static async Task Build(EventHandler<AuthenticationEventArgs> callback) {
      if (m_Client is not null)
        return;

      if (callback is null)
        throw new ArgumentNullException(nameof(callback));

      m_Authentication = new Authentication(ApplicationId, Scope);
      m_Authentication.Authenticate += callback;

      await m_Authentication.GetAccessToken();

      m_Client = new GraphServiceClient(m_Authentication);
    }

    /// <summary>
    /// MS Graph Client to work with
    /// </summary>
    public static GraphServiceClient Client => m_Client;

    #endregion Public
  }

}
